#include <iostream>  // iostream is a header file that defines the standard input/output stream objects

#pragma clang diagnostic push
#pragma clang diagnostic ignored \
    "-Wunused-variable"  // Ignore unused variables warnings as warnings are treated as errors by default.

// main is the function that is called when the program is run
int main() {
  std::cout
      << "Hello World\n";  // std::cout is a stream object that represents the standard output stream
}

#pragma clang diagnostic pop

// Compile: bazel build src/courses-free/hacking_cpp/000.cpp_beginners_guide:p01-000-hello_world
// Run: bazel-bin/src/courses-free/hacking_cpp/000.cpp_beginners_guide:p01-000-hello_world

/* Notes:
- C++ is a compiled language. The source code can't be run directly, it must be compiled into machine code. The program that can be run is a binary executable file containing machine code.
- Terminology:
  - Compiler Error: program doesn't compile, compiler will stop and report the error.
  - Compiler Warning: program compiles, but there is a problematic piece of code that might lead to runtime bugs.
  - static: fixed at compile time (baked into the executable, not changeable at runtime).
  - dynamic: changeable at runtime (possibly by user input).
- Useful compiler flags:
  - -std=c++20: use C++20 standard.
  - -Wall: enable all compiler warnings.
  - -Werror: treat all compiler warnings as errors.
  - -Wpedantic: issue all the warnings demanded by strict ISO C and ISO C++.
  - -Wextra: enable some extra warning flags that are not enabled by -Wall.
- Don't use `using namespace std;` because it can cause name conflicts and ambiguity. Polluting the global namespace with all symbols from other namespaces is a serious liability in any production code base and you should avoid this anti-pattern from the very start.
*/
