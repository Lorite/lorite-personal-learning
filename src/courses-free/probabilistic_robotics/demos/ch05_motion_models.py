"""Sampling motion models (Probabilistic Robotics, Tables 5.3 and 5.6), a live demo.

Draws the sample clouds of the velocity motion model (left, Table 5.3) and the odometry
motion model (right, Table 5.6) for one motion from the same start pose, with a title,
axis names, units and a legend. Three noise presets reproduce the kind of clouds the book
shows (moderate, large translational error, large rotational error). A second switch
splits the same motion into 10 short steps, which shows that the spread depends on the
motion per step (the variances grow with the square of v, omega or the odometry deltas).

The noise parameters are illustrative, not taken from the book.

    uv run python demos/ch05_motion_models.py                  # interactive window
    uv run python demos/ch05_motion_models.py --save f.png     # one image of all presets
"""

import argparse

import matplotlib
import numpy as np

N_SAMPLES = 1000
START = np.array([0.0, 0.0, 0.0])  # x [m], y [m], theta [rad]

# One motion, given to both models: drive about 2 m while turning left.
V, OMEGA, DT = 1.0, 0.35, 2.0  # velocity model control u_t = (v, omega), duration
ROT1, TRANS, ROT2 = 0.35, 2.0, 0.35  # odometry deltas of a similar motion

# alpha_1..alpha_6 for the velocity model, alpha_1..alpha_4 for the odometry model.
PRESETS = {
    "Moderate noise": ((0.02, 0.02, 0.02, 0.02, 0.01, 0.01), (0.02, 0.02, 0.02, 0.02)),
    "Large translational error": (
        (0.3, 0.3, 0.02, 0.02, 0.01, 0.01),
        (0.02, 0.02, 0.3, 0.3),
    ),
    "Large rotational error": (
        (0.02, 0.02, 0.3, 0.3, 0.01, 0.01),
        (0.3, 0.3, 0.02, 0.02),
    ),
}


def sample(var, rng, n):
    """sample(b^2) of the book: zero-mean normal with variance b^2 (Table 5.4)."""
    return rng.normal(0.0, np.sqrt(var), n)


def sample_velocity(pose, v, omega, dt, a, rng):
    """Table 5.3 for N poses at once. pose has shape (3, N)."""
    n = pose.shape[1]
    x, y, th = pose
    v_hat = v + sample(a[0] * v**2 + a[1] * omega**2, rng, n)  # line 2
    w_hat = omega + sample(a[2] * v**2 + a[3] * omega**2, rng, n)  # line 3
    g_hat = sample(a[4] * v**2 + a[5] * omega**2, rng, n)  # line 4
    w_safe = np.where(np.abs(w_hat) < 1e-9, 1e-9, w_hat)  # straight line limit
    r = v_hat / w_safe
    x2 = x - r * np.sin(th) + r * np.sin(th + w_hat * dt)  # line 5
    y2 = y + r * np.cos(th) - r * np.cos(th + w_hat * dt)  # line 6
    th2 = th + w_hat * dt + g_hat * dt  # line 7
    return np.vstack((x2, y2, th2))


def sample_odometry(pose, rot1, trans, rot2, a, rng):
    """Table 5.6 for N poses at once, with the odometry deltas of lines 2 to 4 given."""
    n = pose.shape[1]
    x, y, th = pose
    r1 = rot1 - sample(a[0] * rot1**2 + a[1] * trans**2, rng, n)  # line 5
    tr = trans - sample(
        a[2] * trans**2 + a[3] * rot1**2 + a[3] * rot2**2, rng, n
    )  # line 6
    r2 = rot2 - sample(a[0] * rot2**2 + a[1] * trans**2, rng, n)  # line 7
    return np.vstack(
        (x + tr * np.cos(th + r1), y + tr * np.sin(th + r1), th + r1 + r2)
    )  # lines 8 to 10


def noise_free_velocity(steps):
    poses = [START]
    for _ in range(steps * 20):
        x, y, th = poses[-1]
        dt = DT / (steps * 20)
        poses.append(
            np.array(
                [
                    x - V / OMEGA * np.sin(th) + V / OMEGA * np.sin(th + OMEGA * dt),
                    y + V / OMEGA * np.cos(th) - V / OMEGA * np.cos(th + OMEGA * dt),
                    th + OMEGA * dt,
                ]
            )
        )
    return np.array(poses).T


def run(preset, steps, seed=1):
    """Sample clouds for both models after `steps` steps that together make the same motion."""
    rng = np.random.default_rng(seed)
    a_vel, a_odo = PRESETS[preset]
    pv = np.tile(START[:, None], (1, N_SAMPLES))
    po = pv.copy()
    for _ in range(steps):
        pv = sample_velocity(pv, V, OMEGA, DT / steps, a_vel, rng)
        po = sample_odometry(po, ROT1 / steps, TRANS / steps, ROT2 / steps, a_odo, rng)
    return pv, po


def draw(axes, preset, steps):
    from matplotlib.lines import Line2D

    pv, po = run(preset, steps)
    path = noise_free_velocity(1)
    a_vel, a_odo = PRESETS[preset]
    end_odo = np.array([TRANS * np.cos(ROT1), TRANS * np.sin(ROT1)])
    step_txt = "1 step" if steps == 1 else f"{steps} steps of 1/{steps} of the motion"
    panels = [
        (
            axes[0],
            pv,
            path[:2, -1],
            f"Velocity model (Table 5.3): v = {V} m/s, omega = {OMEGA} rad/s, dt = {DT} s",
            "alpha 1..6 = " + ", ".join(f"{v:g}" for v in a_vel),
        ),
        (
            axes[1],
            po,
            end_odo,
            f"Odometry model (Table 5.6): rot1 = {ROT1}, trans = {TRANS} m, rot2 = {ROT2} rad",
            "alpha 1..4 = " + ", ".join(f"{v:g}" for v in a_odo),
        ),
    ]
    for ax, cloud, end, title, alphas in panels:
        ax.cla()
        ax.scatter(cloud[0], cloud[1], s=3, c="tab:red", alpha=0.35)
        if ax is axes[0]:
            ax.plot(path[0], path[1], "-b", lw=1.5)
        else:
            ax.plot([0, end[0]], [0, end[1]], "-b", lw=1.5)
        ax.plot(*end, "bo", ms=7)
        ax.annotate(
            "", xy=(0.4, 0), xytext=(0, 0), arrowprops={"arrowstyle": "->", "lw": 2}
        )
        ax.plot(0, 0, "ks", ms=7)
        ax.set_title(title, fontsize=9)
        ax.set_xlabel("x [m]")
        ax.set_ylabel("y [m]")
        ax.set_xlim(-1.0, 3.5)
        ax.set_ylim(-1.5, 3.0)
        ax.set_aspect("equal")
        ax.grid(True)
        ax.text(
            0.02,
            0.02,
            f"{alphas}\nspread (std of x, y): {cloud[0].std():.2f} m, {cloud[1].std():.2f} m",
            transform=ax.transAxes,
            fontsize=8,
            va="bottom",
            bbox={"boxstyle": "round", "fc": "white", "alpha": 0.8},
        )
        ax.legend(
            handles=[
                Line2D(
                    [],
                    [],
                    color="k",
                    marker="s",
                    ls="",
                    label="Start pose x_{t-1} (arrow = heading)",
                ),
                Line2D([], [], color="b", lw=1.5, label="Noise-free motion"),
                Line2D(
                    [], [], color="b", marker="o", ls="", label="Noise-free end pose"
                ),
                Line2D(
                    [],
                    [],
                    color="tab:red",
                    marker=".",
                    ls="",
                    label=f"{N_SAMPLES} samples of x_t",
                ),
            ],
            loc="upper left",
            fontsize=7,
        )
    axes[0].figure.suptitle(
        f"Sampling from the motion model p(x_t | u_t, x_t-1): {preset}, {step_txt}"
    )


def main():
    ap = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    ap.add_argument(
        "--save", help="write one image with all presets (1 step and 10 steps) and exit"
    )
    args = ap.parse_args()
    if args.save:
        matplotlib.use("Agg")
    import matplotlib.pyplot as plt
    from matplotlib.widgets import RadioButtons

    if args.save:
        names = list(PRESETS)
        fig, grid = plt.subplots(
            len(names) + 1, 2, figsize=(13, 5.2 * (len(names) + 1))
        )
        for row, name in enumerate(names):
            draw(grid[row], name, 1)
            grid[row][0].set_title(f"{name} | " + grid[row][0].get_title(), fontsize=9)
        draw(grid[-1], names[0], 10)
        grid[-1][0].set_title(
            "Moderate noise, 10 short steps | " + grid[-1][0].get_title(), fontsize=9
        )
        fig.suptitle(
            "Sampling motion models, Probabilistic Robotics chapter 5 (illustrative noise)"
        )
        fig.tight_layout(rect=(0, 0, 1, 0.98))
        fig.savefig(args.save, dpi=90)
        print(f"saved {args.save}")
        return

    fig, axes = plt.subplots(1, 2, figsize=(14, 6.5))
    fig.subplots_adjust(left=0.2, wspace=0.25)
    state = {"preset": "Moderate noise", "steps": 1}
    preset_box = RadioButtons(fig.add_axes([0.01, 0.55, 0.15, 0.2]), list(PRESETS))
    steps_box = RadioButtons(
        fig.add_axes([0.01, 0.3, 0.15, 0.15]), ["1 step", "10 short steps"]
    )
    fig.text(0.01, 0.77, "Noise preset", fontsize=9, weight="bold")
    fig.text(0.01, 0.47, "Same motion as", fontsize=9, weight="bold")

    def update(_=None):
        state["preset"] = preset_box.value_selected
        state["steps"] = 1 if steps_box.value_selected == "1 step" else 10
        draw(axes, state["preset"], state["steps"])
        fig.canvas.draw_idle()

    preset_box.on_clicked(update)
    steps_box.on_clicked(update)
    update()
    plt.show()


if __name__ == "__main__":
    main()
