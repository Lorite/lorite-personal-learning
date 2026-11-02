"""Particle filter localization (Probabilistic Robotics, Table 4.3) with a labeled plot.

Runs the PythonRobotics particle filter (cloned in _external/ by setup.sh) unchanged,
but draws its own animation with a title, axis names, units and a legend, so the
reader can see what each line and dot is while reading chapter 4.

    uv run python demos/ch04_particle_filter.py            # animation (Esc stops it)
    uv run python demos/ch04_particle_filter.py --save f.png  # last frame only, no window
"""

import argparse
import importlib.util
from pathlib import Path

import matplotlib
import numpy as np

HERE = Path(__file__).resolve().parent
PF_PATH = (
    HERE.parent
    / "_external/PythonRobotics/Localization/particle_filter/particle_filter.py"
)


def load_pythonrobotics():
    spec = importlib.util.spec_from_file_location("pr_particle_filter", PF_PATH)
    mod = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(mod)
    mod.show_animation = False
    return mod


def main():
    ap = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    ap.add_argument(
        "--save", help="write the last frame to this PNG instead of animating"
    )
    args = ap.parse_args()
    if args.save:
        matplotlib.use("Agg")
    import matplotlib.pyplot as plt
    from matplotlib.lines import Line2D

    pf = load_pythonrobotics()

    # Count resampling steps (lines 8 to 11 of Table 4.3) without changing the algorithm.
    resamples = []
    original_resampling = pf.re_sampling

    def counting_resampling(px, pw):
        resamples.append(1)
        return original_resampling(px, pw)

    pf.re_sampling = counting_resampling

    rf_id = np.array([[10.0, 0.0], [10.0, 10.0], [0.0, 15.0], [-5.0, 20.0]])
    x_est = np.zeros((4, 1))
    x_true = np.zeros((4, 1))
    x_dr = np.zeros((4, 1))
    px = np.zeros((4, pf.NP))
    pw = np.zeros((1, pf.NP)) + 1.0 / pf.NP
    h_true, h_dr, h_est = x_true, x_dr, x_est

    fig, ax = plt.subplots(figsize=(9, 8))
    fig.canvas.mpl_connect(
        "key_release_event", lambda e: plt.close(fig) if e.key == "escape" else None
    )

    def draw(time, z, p_est):
        ax.cla()
        for i in range(len(z[:, 0])):
            ax.plot(
                [x_true[0, 0], z[i, 1]],
                [x_true[1, 0], z[i, 2]],
                "-",
                color="0.6",
                lw=0.8,
            )
        ax.plot(rf_id[:, 0], rf_id[:, 1], "*k", ms=12)
        ax.plot(px[0, :], px[1, :], ".r", ms=4, alpha=0.6)
        ax.plot(h_true[0, :], h_true[1, :], "-b", lw=2)
        ax.plot(h_dr[0, :], h_dr[1, :], "-k", lw=1)
        ax.plot(h_est[0, :], h_est[1, :], "-r", lw=1.5)
        plt.sca(ax)
        pf.plot_covariance_ellipse(x_est, p_est)
        ax.set_title(
            f"Particle filter localization (book Table 4.3), t = {time:4.1f} s of {pf.SIM_TIME:.0f} s"
        )
        ax.set_xlabel("x [m]")
        ax.set_ylabel("y [m]")
        ax.axis("equal")
        ax.grid(True)
        handles = [
            Line2D([], [], color="b", lw=2, label="True path (simulated robot)"),
            Line2D(
                [],
                [],
                color="k",
                lw=1,
                label="Dead reckoning (odometry only, no filter)",
            ),
            Line2D(
                [],
                [],
                color="r",
                lw=1.5,
                label="Particle filter estimate (weighted mean)",
            ),
            Line2D([], [], color="r", ls="--", label="Estimate covariance ellipse"),
            Line2D(
                [], [], color="r", marker=".", ls="", label=f"Particles (M = {pf.NP})"
            ),
            Line2D(
                [],
                [],
                color="k",
                marker="*",
                ms=12,
                ls="",
                label="Landmarks (known positions)",
            ),
            Line2D(
                [],
                [],
                color="0.6",
                lw=0.8,
                label=f"Range measurements z_t (max {pf.MAX_RANGE:.0f} m)",
            ),
        ]
        ax.legend(handles=handles, loc="upper left", fontsize=8)
        ax.text(
            0.99,
            0.99,
            f"Resampling steps so far: {len(resamples)}\n"
            f"(the filter resamples when N_eff < M/2 = {pf.NTh:.0f})",
            transform=ax.transAxes,
            ha="right",
            va="top",
            fontsize=8,
            bbox={"boxstyle": "round", "fc": "white", "alpha": 0.8},
        )

    time = 0.0
    while pf.SIM_TIME >= time:
        time += pf.DT
        u = pf.calc_input()
        x_true, z, x_dr, ud = pf.observation(x_true, x_dr, u, rf_id)
        x_est, p_est, px, pw = pf.pf_localization(px, pw, z, ud)
        h_true = np.hstack((h_true, x_true))
        h_dr = np.hstack((h_dr, x_dr))
        h_est = np.hstack((h_est, x_est))
        if not args.save:
            if not plt.fignum_exists(fig.number):
                return
            draw(time, z, p_est)
            plt.pause(0.001)
    draw(time, z, p_est)
    if args.save:
        fig.savefig(args.save, dpi=110, bbox_inches="tight")
        print(f"saved {args.save}, resampling steps: {len(resamples)}")
    else:
        plt.show()


if __name__ == "__main__":
    main()
