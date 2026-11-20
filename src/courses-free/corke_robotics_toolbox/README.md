# Robotics Toolbox for Python, hands-on

Companion notebooks for Peter Corke's [Robotics Toolbox for Python](https://github.com/petercorke/robotics-toolbox-python) (`roboticstoolbox-python`) and its [Spatial Maths](https://github.com/bdaiinstitute/spatialmath-python) library, with the book _Robotics, Vision and Control: Fundamental Algorithms in Python_ (Peter Corke, Springer, 3rd edition 2023, [doi:10.1007/978-3-031-06469-2](https://doi.org/10.1007/978-3-031-06469-2)) as the text to read after the run. The method is the same as in the [probabilistic robotics course](../probabilistic_robotics/README.md): run the algorithm first, then read with the questions the code produced.

This folder covers robot arms: poses, kinematics, Jacobians and velocity control. State estimation (filters, localization, SLAM) lives in the probabilistic robotics course.

## Setup

```bash
uv sync             # creates .venv with Python 3.13 and the toolbox (version pinned in uv.lock)
uv run jupyter lab  # opens the notebooks
```

No external clones are needed. The toolbox ships its robot models (Panda, UR5, Puma 560 and others) inside the Python package. The 3-D browser simulator Swift is optional (`uv add "roboticstoolbox-python[swift]"`). The notebooks use plain matplotlib figures, so they also run headless and render on GitHub.

## Notebooks

| Notebook                                                                 | Run                                                                                                                                                            | Read in the book                                                                        |
| ------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| [`notebooks/01_arm_kinematics.ipynb`](notebooks/01_arm_kinematics.ipynb) | `SE3` poses, forward and inverse kinematics of the Panda, the Jacobian and manipulability, a resolved-rate controller as your own loop, null-space self-motion | "Representing Position and Orientation", "Robot Arm Kinematics", "Manipulator Velocity" |

Ideas for the next notebooks: dynamics and computed-torque control ("Dynamics and Control"), and a mobile manipulator (the toolbox's `Frankie` model, a Panda on a mobile base) as a small version of Spot with its arm, where the base and arm together are redundant for the gripper task.

## Notebook structure

Every notebook follows the same four parts:

1. **Run** the toolbox functions through your own loop, so the equations stay visible.
2. **Make it yours**: one modification with a plot that answers a question (for notebook 01, the null-space term that raises manipulability while the hand stays still).
3. **Questions for the reading group**, produced by the run.
4. **Now read**: the book chapters tied to the cells above.

## Conventions

- Plain Python with uv, no ROS, no Bazel targets. The folder has no `BUILD.bazel` file, so the monorepo's `bazel build //...` ignores it.
- Notebooks are committed with their outputs so that the figures render on GitHub. Re-execute one with `uv run jupyter nbconvert --to notebook --execute --inplace notebooks/<name>.ipynb`.
- Two API details cost time on the first try and are documented in notebook 01: `ik_LM` returns an `IKSolution` object (use `.q`, `.success`), and `rtb.p_servo` returns the velocity in the hand frame, so it pairs with `jacobe`, not with `jacob0`.
