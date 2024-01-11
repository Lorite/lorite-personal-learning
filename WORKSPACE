workspace(name = "lorite_ws")

# ----------------------------------------

# bazel

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

# ----------------------------------------

# C# - DotNet

http_archive(
    name = "rules_dotnet",
    sha256 = "5667f2dffb40890951662ec515bc2d5fca73126fbb69607b2ab451a644cc986d",
    strip_prefix = "rules_dotnet-0.11.0",
    url = "https://github.com/bazelbuild/rules_dotnet/releases/download/v0.11.0/rules_dotnet-v0.11.0.tar.gz",
)

load(
    "@rules_dotnet//dotnet:repositories.bzl",
    "dotnet_register_toolchains",
    "rules_dotnet_dependencies",
)

rules_dotnet_dependencies()

# Here you can specify the version of the .NET SDK to use.
dotnet_register_toolchains("dotnet", "7.0.101")

load("@rules_dotnet//dotnet:rules_dotnet_nuget_packages.bzl", "rules_dotnet_nuget_packages")

rules_dotnet_nuget_packages()

load("//src/examples/bazel-test-project-csharp:example_deps.bzl", "example_deps")

example_deps()

# ----------------------------------------

# Python

# Load external dependencies
# Python rules for Bazel, which provide the basis of support for Python in Bazel
RULES_PYTHON_VERSION="0.26.0"
RULES_PYTHON_SHA="9d04041ac92a0985e344235f5d946f71ac543f1b1565f2cdbc9a2aaee8adf55b"
http_archive(
    name = "rules_python",
    sha256 = RULES_PYTHON_SHA,
    strip_prefix = "rules_python-{}".format(RULES_PYTHON_VERSION),
    url = "https://github.com/bazelbuild/rules_python/releases/download/{}/rules_python-{}.tar.gz".format(RULES_PYTHON_VERSION,RULES_PYTHON_VERSION),
)
load("@rules_python//python:repositories.bzl", "py_repositories")
py_repositories()

# Select the Python toolchain
load("@rules_python//python:repositories.bzl", "python_register_toolchains")
python_register_toolchains(
    name = "python_3_10",
    # Available versions are listed in @rules_python//python:versions.bzl.
    # We recommend using the same version your team is already standardized on.
    python_version = "3.10",
    register_coverage_tool = True,
)
load("@python_3_10//:defs.bzl", "interpreter")

# Python pip dependencies from requirements.txt 
load("@rules_python//python:pip.bzl", "pip_parse")
# src/examples/bazel-test-project-python-flask
pip_parse(
    name = "pip_bazel_test_deps",
    requirements_lock = "//src/examples/bazel-test-project-python-flask:requirements.txt",
    # python_interpreter_target = interpreter,
)
load("@pip_bazel_test_deps//:requirements.bzl", install_deps_bazel_test = "install_deps")
install_deps_bazel_test()

# ----------------------------------------

# C++ - Cpp

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
http_archive(
  name = "com_google_googletest",
  urls = ["https://github.com/google/googletest/archive/5ab508a01f9eb089207ee87fd547d290da39d015.zip"],
  strip_prefix = "googletest-5ab508a01f9eb089207ee87fd547d290da39d015",
)

# linting - clangd
# Hedron's Compile Commands Extractor for Bazel
# https://github.com/hedronvision/bazel-compile-commands-extractor
http_archive(
    name = "hedron_compile_commands",
    # Replace the commit hash (6d58fa6bf39f612304e55566fa628fd160b38177) in both places (below) with the latest (https://github.com/hedronvision/bazel-compile-commands-extractor/commits/main), rather than using the stale one here.
    # TODO: Even better, set up Renovate and let it do the work for you (see "Suggestion: Updates" in the README).
    url = "https://github.com/hedronvision/bazel-compile-commands-extractor/archive/6d58fa6bf39f612304e55566fa628fd160b38177.tar.gz",
    strip_prefix = "bazel-compile-commands-extractor-6d58fa6bf39f612304e55566fa628fd160b38177",
    # When you first run this tool, it'll recommend a sha256 hash to put here with a message like: "DEBUG: Rule 'hedron_compile_commands' indicated that a canonical reproducible form can be obtained by modifying arguments sha256 = ..."
)

# llvm tools
load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
http_archive(
    name = "toolchains_llvm",
    sha256 = "b7cd301ef7b0ece28d20d3e778697a5e3b81828393150bed04838c0c52963a01",
    strip_prefix = "toolchains_llvm-0.10.3",
    canonical_id = "0.10.3",
    url = "https://github.com/grailbio/bazel-toolchain/releases/download/0.10.3/toolchains_llvm-0.10.3.tar.gz",
)
load("@toolchains_llvm//toolchain:deps.bzl", "bazel_toolchain_dependencies")
bazel_toolchain_dependencies()
load("@toolchains_llvm//toolchain:rules.bzl", "llvm_toolchain")
llvm_toolchain(
    name = "llvm_toolchain",
    llvm_version = "16.0.0",
)
load("@llvm_toolchain//:toolchains.bzl", "llvm_register_toolchains")
llvm_register_toolchains()

# ----------------------------------------

# LaTeX

http_archive(
    name = "bazel_latex",
    sha256 = "82c99edaca50f938cb4881650737174eefedac844350b530942b874540400610",
    strip_prefix = "bazel-latex-1.2.1",
    url = "https://github.com/ProdriveTechnologies/bazel-latex/archive/v1.2.1.tar.gz",
    patches = [
        "@//third_party/bazel-latex:0001-add-seqsplit-package-support.patch",
    ],
    patch_args = ["-p1"],
)

load("@bazel_latex//:repositories.bzl", "latex_repositories")

latex_repositories()
