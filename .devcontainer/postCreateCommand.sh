#!/bin/bash
uname -a

# Source custom environment
if [ -f .devcontainer/lorite-scripts/custom_env.sh ]; then
	. .devcontainer/lorite-scripts/custom_env.sh
else
	echo "No custom environment file found"
fi
