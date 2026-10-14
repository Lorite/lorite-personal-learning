#!/bin/bash
uname -a

# Python: the distribution's python3 comes from the python dev container feature (os-provided) because Bazel's helper scripts need it.
# Bazel brings its own interpreter and pip packages (rules_python) for the targets, and the plain Python courses use uv, so nothing is pip-installed here.

# zsh terminal
cp .devcontainer/lorite-scripts/.zshrc $HOME/.zshrc
cp .devcontainer/lorite-scripts/.p10k.zsh $HOME/.p10k.zsh
git clone --depth=1 https://github.com/romkatv/powerlevel10k.git ${ZSH_CUSTOM:-$HOME/.oh-my-zsh/custom}/themes/powerlevel10k
cd $HOME && curl -fsSLO https://raw.githubusercontent.com/romkatv/dotfiles-public/master/.purepower

# run bazel lint
.devcontainer/lorite-scripts/enable_bazel_lint.sh

# custom aliases: written to a file that oh-my-zsh sources on every shell (aliases defined in this script would be lost when it exits)
mkdir -p "${ZSH_CUSTOM:-$HOME/.oh-my-zsh/custom}"
cat <<'ALIASES' >"${ZSH_CUSTOM:-$HOME/.oh-my-zsh/custom}/lorite-aliases.zsh"
alias clean_squash_merged_local_git_branches='git checkout -q main && git for-each-ref refs/heads/ "--format=%(refname:short)" | while read branch; do mergeBase=$(git merge-base main $branch) && [[ $(git cherry main $(git commit-tree $(git rev-parse "$branch^{tree}") -p $mergeBase -m _)) == "-"* ]] && git branch -D $branch; done'
alias clean_squash_merged_local_git_branches_dry_run='git checkout -q main && git for-each-ref refs/heads/ "--format=%(refname:short)" | while read branch; do mergeBase=$(git merge-base main $branch) && [[ $(git cherry main $(git commit-tree $(git rev-parse "$branch^{tree}") -p $mergeBase -m _)) == "-"* ]] && echo "$branch is merged into main and can be deleted"; done'
# The Bazel-managed interpreter only exists after a build has created the external/ symlink. Outside Bazel, use uv (uv run python).
alias python='echo "**Please use Python inside Bazel to have access to pip packages, or uv for the plain Python courses.**"; /workspaces/lorite-personal-learning/external/rules_python++python+python_3_13_x86_64-unknown-linux-gnu/bin/python3'
ALIASES

# Source custom environment
if [ -f .devcontainer/lorite-scripts/custom_env.sh ]; then
	. .devcontainer/lorite-scripts/custom_env.sh
else
	echo "No custom environment file found"
fi
