# Probabilistic Robotics, hands-on

Companion notebooks for the book *Probabilistic Robotics* (Sebastian Thrun, Wolfram Burgard, Dieter Fox, MIT Press 2005), made for a weekly reading group. The idea is simple: run the algorithm first, then read the chapter with the questions the code produced. Nothing here is a new implementation. The notebooks import the functions of well-known open source repositories, write their own loop around them so the equations stay visible, and add one modification exercise per chapter.

## Setup

```bash
./setup.sh          # shallow-clones the external repositories into _external/ (gitignored, pinned commits)
uv run jupyter lab  # opens the notebooks, Python 3.13 environment managed by uv
```

Inside the repository's dev container, uv comes from the `uv` dev container feature and port 8888 is forwarded, so the same two commands work there (open the notebooks in VS Code with the Jupyter extension, or in the browser through the forwarded port). When you switch between the host and the container, run `uv sync` again, because the `.venv` folder is bound to the path it was created at.

The external repositories are read-only references. They are not vendored because of their size and their different licenses, see `setup.sh` for the exact commits and the license of each.

- [PythonRobotics](https://github.com/AtsushiSakai/PythonRobotics) (Atsushi Sakai, MIT): one readable script per algorithm, localization, mapping and SLAM, with the book as its reference.
- [Kalman and Bayesian Filters in Python](https://github.com/rlabbe/Kalman-and-Bayesian-Filters-in-Python) (Roger Labbe): a textbook written as Jupyter notebooks, with exercises and solutions, and the FilterPy library.
- [Probabilistic-Robotics-Algorithms](https://github.com/ChengeYang/Probabilistic-Robotics-Algorithms) (Chenge Yang): EKF and particle filter localization, EKF-SLAM, graph SLAM and FastSLAM on the public UTIAS MRCLAM dataset, each with the book page number of the algorithm.

Articles and videos per chapter come from the ROS 2 series [rse_prob_robotics](https://github.com/carlos-argueta/rse_prob_robotics) by Carlos Argueta and from the [University of Bonn online robotics lectures](https://www.ipb.uni-bonn.de/online-training-robotics/) by Cyrill Stachniss. Those are for watching and reading, the notebooks here stay ROS-free.

## Chapter map

Book pages refer to the MIT Press edition. "Run" is what to execute before reading, "Read" is the text with the questions in mind, "Watch" is optional.

| Chapter | Pages | Run | Read | Watch |
| --- | --- | --- | --- | --- |
| 2 Recursive state estimation | 13 to 38 | rlabbe `02-Discrete-Bayes.ipynb` | 2.3 and 2.4, the Bayes filter and Table 2.1 | [KF demo video](https://youtu.be/TPbO3kBygb4) as a preview of chapter 3 |
| 3 Gaussian filters | 39 to 84 | [`notebooks/ch03_gaussian_filters.ipynb`](notebooks/ch03_gaussian_filters.ipynb), then rlabbe `04` and `06`, PythonRobotics `Localization/extended_kalman_filter` and `unscented_kalman_filter` | 3.2 to 3.4 as mapped in the notebook | [KF article](https://medium.com/@kidargueta/recursive-state-estimation-with-kalman-filters-and-ros-2-b869d3775357), [EKF article](https://medium.com/@kidargueta/sensor-fusion-with-the-extended-kalman-filter-in-ros-2-d33dbab1829d) |
| 4 Nonparametric filters | 85 to 116 | rlabbe `12-Particle-Filters.ipynb`, PythonRobotics `Localization/histogram_filter` and `particle_filter` | 4.1 histogram filter, 4.3 particle filter | [Particle filter article, part 1](https://soulhackerslabs.com/robot-state-estimation-with-the-particle-filter-in-ros-2-part-1-e19bd286dfd6) |
| 5 Robot motion | 117 to 148 | PythonRobotics motion models inside the localization scripts | 5.3 velocity model, 5.4 odometry model | Bonn lectures on motion models |
| 6 Robot perception | 149 to 188 | PythonRobotics `Mapping/ray_casting_grid_map` | 6.3 beam model, 6.4 likelihood field, 6.6 landmark model | Bonn lectures on sensor models |
| 7 Mobile robot localization, Markov and Gaussian | 189 to 236 | PythonRobotics `Localization/extended_kalman_filter`, ChengeYang `1.Localization` EKF on UTIAS data | 7.4 EKF localization and Table 7.2 (the innovation gate) | |
| 8 Mobile robot localization, grid and Monte Carlo | 237 to 280 | PythonRobotics `Localization/particle_filter`, ChengeYang `1.Localization` MCL | 8.3 Monte Carlo localization | Bonn lecture on Monte Carlo localization |
| 9 Occupancy grid mapping | 281 to 308 | PythonRobotics `Mapping/lidar_to_grid_map` and `gaussian_grid_map` | 9.2 the log odds update | rse_prob_robotics occupancy grid article |
| 10 Simultaneous localization and mapping | 309 to 336 | PythonRobotics `SLAM/EKFSLAM`, ChengeYang `2.EKF_SLAM` | 10.2 EKF SLAM with known correspondences | |
| 11 The GraphSLAM algorithm | 337 to 384 | PythonRobotics `SLAM/GraphBasedSLAM`, ChengeYang `3.Graph_SLAM` | 11.3 and 11.4 | Bonn lectures on graph-based SLAM |
| 13 The FastSLAM algorithm | 437 to 484 | PythonRobotics `SLAM/FastSLAM1` and `FastSLAM2`, ChengeYang `4.Fast_SLAM_1` and `5.Fast_SLAM_2` | 13.1 to 13.3 | |

Chapters 12 (sparse extended information filter) and 14 to 17 (Markov decision processes, POMDPs, exploration) have no runnable companion here yet.

## Notebook structure

Every chapter notebook follows the same four parts, so the habit stays the same:

1. **Run** the external example through your own loop, with the book's table and line numbers as comments.
2. **Make it yours**: one modification with a plot that answers a question (for chapter 3, a measurement noise that grows with range against a constant one, judged by the innovation statistics).
3. **Questions for the reading group**, produced by the run.
4. **Now read**: the book sections tied to the cells above.

## Conventions

- Plain Python with uv, no ROS, no Bazel targets for now. The folder is invisible to the monorepo's `bazel build //...` because it has no `BUILD.bazel` file. The CI formatter runs ruff on `.py` files and leaves the notebooks alone.
- Notebooks are committed with their outputs so that the figures render on GitHub.
- Datasets stay public (the UTIAS MRCLAM dataset through the ChengeYang clone, PythonRobotics simulations). Check the dataset terms before copying data into this folder.
