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

# ----------------------------------------

# Javascript

http_archive(
    name = "aspect_rules_js",
    sha256 = "7ab9776bcca823af361577a1a2ebb9a30d2eb5b94ecc964b8be360f443f714b2",
    strip_prefix = "rules_js-1.32.6",
    url = "https://github.com/aspect-build/rules_js/releases/download/v1.32.6/rules_js-v1.32.6.tar.gz",
)

load("@aspect_rules_js//js:repositories.bzl", "rules_js_dependencies")

rules_js_dependencies()

load("@rules_nodejs//nodejs:repositories.bzl", "DEFAULT_NODE_VERSION", "nodejs_register_toolchains")

nodejs_register_toolchains(
    name = "nodejs",
    node_version = DEFAULT_NODE_VERSION,
)

load("@aspect_rules_js//npm:repositories.bzl", "npm_translate_lock")

npm_translate_lock(
    name = "npm",
    npmrc = "//tools/formatter:.npmrc",
    pnpm_lock = "//tools/formatter:pnpm-lock.yaml",
    verify_node_modules_ignored = "//tools/formatter:.bazelignore",
)

load("@npm//:repositories.bzl", "npm_repositories")

npm_repositories()

# ----------------------------------------

# TypeScript - Required for formatting and linting with prettier

http_archive(
    name = "aspect_rules_ts",
    sha256 = "8eb25d1fdafc0836f5778d33fb8eaac37c64176481d67872b54b0a05de5be5c0",
    strip_prefix = "rules_ts-1.3.3",
    url = "https://github.com/aspect-build/rules_ts/releases/download/v1.3.3/rules_ts-v1.3.3.tar.gz",
)

load("@aspect_rules_ts//ts:repositories.bzl", "rules_ts_dependencies")

rules_ts_dependencies(
    ts_version_from = "//tools/formatter:package.json",
)

# ----------------------------------------

# Buldifier - Required for formatting and linting Bazel

http_archive(
    name = "buildifier_prebuilt",
    sha256 = "72b5bb0853aac597cce6482ee6c62513318e7f2c0050bc7c319d75d03d8a3875",
    strip_prefix = "buildifier-prebuilt-6.3.3",
    urls = [
        "http://github.com/keith/buildifier-prebuilt/archive/6.3.3.tar.gz",
    ],
)

load("@buildifier_prebuilt//:deps.bzl", "buildifier_prebuilt_deps")

buildifier_prebuilt_deps()

load("@bazel_skylib//:workspace.bzl", "bazel_skylib_workspace")

bazel_skylib_workspace()

load("@buildifier_prebuilt//:defs.bzl", "buildifier_prebuilt_register_toolchains")

buildifier_prebuilt_register_toolchains()

# ----------------------------------------

# Formatting and linting

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
http_archive(
    name = "aspect_rules_lint",
    sha256 = "ddc21b1399c03708f82e5a46d6c747bf23d55484bad1efdaa92a22d5fee20ea1",
    strip_prefix = "rules_lint-0.5.0",
    url = "https://github.com/aspect-build/rules_lint/releases/download/v0.5.0/rules_lint-v0.5.0.tar.gz",
)

# Use whichever formatter binaries you need:
load(
    "@aspect_rules_lint//format:repositories.bzl",
    # "fetch_java_format",
    "fetch_jsonnet",
    # "fetch_ktfmt",
    "fetch_pmd",
    "fetch_shfmt",
    "fetch_swiftformat",
    # "fetch_terraform",
)

fetch_pmd()

fetch_jsonnet()

# fetch_terraform()

# fetch_java_format()

# fetch_ktfmt()

fetch_shfmt()

fetch_swiftformat()

load("@aspect_rules_lint//lint:ruff.bzl", "fetch_ruff")

fetch_ruff()

load("@aspect_rules_lint//lint:shellcheck.bzl", "fetch_shellcheck")

fetch_shellcheck()