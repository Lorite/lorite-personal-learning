#!/bin/bash
BAZEL_TYPE=$1 # bazel build and bazel test work; bazel run does not.
FILEPATH=$2

TARGETS=$(mktemp)
trap "rm -f $TARGETS" EXIT

bazel query "rdeps(set(src/... cheatsheets/...), ${FILEPATH})" --keep_going 2>/dev/null >"$TARGETS"
bazel "$BAZEL_TYPE" --target_pattern_file="$TARGETS" ${@:3}

# returns the file that is built
# FIRST_TARGET=$(head -n 1 "$TARGETS")
# bazel cquery "$FIRST_TARGET" --output files 2>/dev/null 