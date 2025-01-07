# Statement

Please write a maintainable solution for the question on page 2, using the rules given below:

The solution must be written in C++.

You will be given a triangle input (which is a directed graph) and you need to find the path that provides the maximum possible sum of the numbers per the given rules below:

1. You will start from the top and move downwards to the last possible node.
2. You must proceed by changing between even and odd numbers subsequently. Suppose that you are on an even number, the next number you choose must be odd, or if you are on an odd number the next number must be even. In other words, the final path would be Odd -> even -> odd -> even …
3. You must reach to the bottom of the pyramid.
4. Assume that there is at least one valid path to the bottom.
5. If there are multiple paths, which result in the same maximum amount, you can choose any of them.

## Sample Input

1
8 9
1 5 9
4 5 2 3

## Output

Max sum: 16

Path: 1, 8, 5, 2

## Explanation

As you can see this triangle has several paths: 1->8->5->2, 1->9->9->3, 1->8->1->4, etc.

The correct answer is 1 + 8 + 5 + 2 = 16. Because since 1 (top most number) is odd we cannot step onto 9 because 9 is an odd number too. The only number we can move to is 8. From 8 we can step to 1 or 5. Only 1 -> 8 -> 5 -> 2 sequence gives us the maximum sum. The other path 1-> 8 -> 1 -> 4 is also a valid path but it sums up to 14. Since 16 is greater than 14, 16 is the solution. Also, note that the solution is in the form of odd > even > odd > even.

## Question

Per the above rules, what is the maximum sum of the below input? Please take this pyramid as an input (as a file, or constants directly inside the code) for your implementation and solve it.

215
192 124
117 269 442
218 836 347 235
320 805 522 417 345
229 601 728 835 133 124
248 202 277 433 207 263 257
359 464 504 528 516 716 871 182
461 441 426 656 863 560 380 171 923
381 348 573 533 448 632 387 176 975 449
223 711 445 645 245 543 931 532 937 541 444
330 131 333 928 376 733 017 778 839 168 197 197
131 171 522 137 217 224 291 413 528 520 227 229 928
223 626 034 683 839 052 627 310 713 999 629 817 410 121
924 622 911 233 325 139 721 218 253 223 107 233 230 124 233

Note that, each node has only two children here (except the bottom row). As an example, you can walk from 215 to 124 or 192, and then from 124 to 269, since 442 is even just like its parent. From 124 you cannot go to 117 because it is not a direct child of 124.

# Notes about the solution

The code is built using [bazel](https://bazel.build/) and [clang](https://clang.llvm.org/). The code is tested using [Google Test](https://github.com/google/googletest). The code is linted using [clang-tidy](https://clang.llvm.org/extra/clang-tidy/). The code is debugged using [VS Code](https://code.visualstudio.com/docs/editor/debugging) and [LLDB](https://lldb.llvm.org/). The code is formatted using [clang-format](https://clang.llvm.org/docs/ClangFormat.html) and it follows the [Google C++ Style Guide](https://google.github.io/styleguide/cppguide.html). The code is documented using [Doxygen](https://www.doxygen.nl/). The code is logged using the [C++ implementation of Google logging module](https://github.com/google/glog).

## File structure

The package is organized as follows:

- [`include/company000/`](include/company000/): contains the header files.
- [`main/`](main/): contains the main files.
- [`src/`](src/): contains the source files.
- [`test/`](test/): contains the test files.
- [`BUILD.bazel`](BUILD.bazel): contains the bazel build configuration.
- [`README.md`](README.md): this file.

## How to build, test, and run the solution

As mentioned, the solution is built, tested, and run using bazel. If you don't have bazel installed, you can install it following the instructions [here](https://docs.bazel.build/versions/main/install.html), or use [Development Containers](https://containers.dev/) and the following [feature](https://containers.dev/features): `ghcr.io/balazs23/devcontainers-features/bazel:1`.

The following commands are available:

```bash
bazel build //src/exercises/job_interviews/company000/...
bazel test //src/exercises/job_interviews/company000/...
bazel run //src/exercises/job_interviews/company000:exercise_1 --src/exercises/job_interviews/company000/data/exercise_1_graph.txt
```

## How to debug the solution

Use the VS Code debugger with the provided launch configuration from the .cpp file to be debugged. The file has to be a test file or the main file (`main/exercise_1.cpp`). The bazel target and the file name have to match for the VS Code launch configuration to work.

# Output from running the solution

- Maximum path:
  Path:
  Total value: 8186
  Nodes: 215 -> 192 -> 269 -> 836 -> 805 -> 728 -> 433 -> 528 -> 863 -> 632 -> 931 -> 778 -> 413 -> 310 -> 253
