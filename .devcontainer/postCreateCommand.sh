#!/bin/bash
uname -a

pip install -r src/examples/bazel-test-project-python-flask/requirements.in # TODO: CHECK AND this could be more elaborate to find all requirements.in files in the folders under src, for example.

# zsh terminal
cp .devcontainer/lorite-scripts/.zshrc $HOME/.zshrc
cp .devcontainer/lorite-scripts/.p10k.zsh $HOME/.p10k.zsh
git clone --depth=1 https://github.com/romkatv/powerlevel10k.git ${ZSH_CUSTOM:-$HOME/.oh-my-zsh/custom}/themes/powerlevel10k
cd $HOME && curl -fsSLO https://raw.githubusercontent.com/romkatv/dotfiles-public/master/.purepower

# bazel-toolchain (llvm) for clangd (C/C++ language server) dependencies
sudo apt-get -qq -y install libtinfo5 >/dev/null

# Source custom environment
if [ -f .devcontainer/lorite-scripts/custom_env.sh ]; then
	. .devcontainer/lorite-scripts/custom_env.sh
else
	echo "No custom environment file found"
fi
