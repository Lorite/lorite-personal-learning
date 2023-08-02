#!/bin/bash
uname -a

# Source custom environment
if [ -f custom_env.sh ]; then
	. custom_env.sh
fi
