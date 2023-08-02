workspace(name = "lorite_ws")


# Load external dependencies
# Python rules for Bazel, which provide the basis of support for Python in Bazel
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
http_archive(
    name = "rules_python",
    sha256 = "8c8fe44ef0a9afc256d1e75ad5f448bb59b81aba149b8958f02f7b3a98f5d9b4",
    strip_prefix = "rules_python-0.13.0",
    url = "https://github.com/bazelbuild/rules_python/archive/refs/tags/0.13.0.tar.gz",
)


# Python pip dependencies from requirements.txt 
load("@rules_python//python:pip.bzl", "pip_parse")

# src/examples/bazel-test-project-python-flask
pip_parse(
    name = "pip_bazel_test_deps",
    requirements_lock = "//src/examples/bazel-test-project-python-flask:requirements.in",
)
load("@pip_bazel_test_deps//:requirements.bzl", install_deps_bazel_test = "install_deps")
install_deps_bazel_test()