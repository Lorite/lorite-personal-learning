#!/bin/bash
uname -a

pip install -r src/examples/bazel-test-project-python-flask/requirements.in # TODO: CHECK AND this could be more elaborate to find all requirements.in files in the folders under src, for example.

# zsh terminal
cp .devcontainer/lorite-scripts/.zshrc $HOME/.zshrc
cp .devcontainer/lorite-scripts/.p10k.zsh $HOME/.p10k.zsh
git clone --depth=1 https://github.com/romkatv/powerlevel10k.git ${ZSH_CUSTOM:-$HOME/.oh-my-zsh/custom}/themes/powerlevel10k
cd $HOME && curl -fsSLO https://raw.githubusercontent.com/romkatv/dotfiles-public/master/.purepower

# bazel-toolchain (llvm) for clangd (C/C++ language server) dependencies
sudo apt-get update >/dev/null && sudo apt-get -qq -y install libtinfo5 >/dev/null

# run bazel lint
.devcontainer/lorite-scripts/enable_bazel_lint.sh

# custom aliases
alias clean_squash_merged_local_git_branches='git checkout -q main && git for-each-ref refs/heads/ "--format=%(refname:short)" | while read branch; do mergeBase=$(git merge-base main $branch) && [[ $(git cherry main $(git commit-tree $(git rev-parse "$branch^{tree}") -p $mergeBase -m _)) == "-"* ]] && git branch -D $branch; done'
alias clean_squash_merged_local_git_branches_dry_run='git checkout -q main && git for-each-ref refs/heads/ "--format=%(refname:short)" | while read branch; do mergeBase=$(git merge-base main $branch) && [[ $(git cherry main $(git commit-tree $(git rev-parse "$branch^{tree}") -p $mergeBase -m _)) == "-"* ]] && echo "$branch is merged into main and can be deleted"; done'
alias python='echo "**Please use Python inside Bazel to have access to pip packages.**"; /workspaces/lorite-personal-learning/external/rules_python++python+python_3_13_x86_64-unknown-linux-gnu/bin/python3'

# Source custom environment
if [ -f .devcontainer/lorite-scripts/custom_env.sh ]; then
	. .devcontainer/lorite-scripts/custom_env.sh
else
	echo "No custom environment file found"
fi
