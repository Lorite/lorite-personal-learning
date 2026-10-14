#!/usr/bin/env bash
# Shallow-clone the external repositories this course runs. They are read-only and gitignored (_external/).
# Pinned to the commits checked on 2026-10-14. Re-run to recreate them, use --update to move a clone to its pin.
set -euo pipefail

here="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
ext="${here}/_external"
mkdir -p "${ext}"

clone_pinned() {
	local name="$1" url="$2" sha="$3"
	local dir="${ext}/${name}"
	if [[ ! -d "${dir}/.git" ]]; then
		echo "cloning ${name} at ${sha:0:12}"
		git init -q "${dir}"
		git -C "${dir}" remote add origin "${url}"
	fi
	git -C "${dir}" fetch -q --depth=1 origin "${sha}"
	git -C "${dir}" checkout -q --detach FETCH_HEAD
	echo "${name}: $(git -C "${dir}" rev-parse --short HEAD)"
}

# Python sample codes and textbook for robotics algorithms (MIT License).
clone_pinned PythonRobotics https://github.com/AtsushiSakai/PythonRobotics.git cdd0cc888802b584c2d654ca85e3c5460973487d
# Kalman and Bayesian Filters in Python, a Jupyter notebook book (text CC BY-NC-SA 4.0, code MIT, see its license.html).
clone_pinned Kalman-and-Bayesian-Filters-in-Python https://github.com/rlabbe/Kalman-and-Bayesian-Filters-in-Python.git 04b2bea802321086effbd99402fc13c893d11110
# Localization and SLAM algorithms of the book on the UTIAS MRCLAM dataset (no license file, read-only reference).
clone_pinned Probabilistic-Robotics-Algorithms https://github.com/ChengeYang/Probabilistic-Robotics-Algorithms.git b597045a9dd86bbb93799607691d7cc3f4e7d8b8

echo "done. Open the notebooks with: cd ${here} && uv run jupyter lab"
