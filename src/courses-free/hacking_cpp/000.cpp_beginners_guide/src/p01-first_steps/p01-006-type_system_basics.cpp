#include <cstdint>
#include <iostream>

// Constant expression
constexpr int32_t foo(int32_t x) {
  return x * 2;
}

int main() {
  // Declare Constants With const
  // <type> const <name> = <value>;
  const int32_t i = 1;
  std::cout << i << '\n';  // 1
  // i = 2; // error: assignment of read-only variable 'i'

  // Type Aliases With using
  // using <alias> = <type>; // C++11
  // typedef <type> <alias>; // C++98 AVOID!!!!
  using Int32 = int32_t;
  Int32 j = 2;
  std::cout << j << '\n';  // 2

  // Type Deduction With auto
  // auto <name> = <value>;
  auto k = 3;              // int
  std::cout << k << '\n';  // 3
  auto l = 3.14;           // double
  std::cout << l << '\n';  // 3.14
  auto m = 3.14f;          // float
  std::cout << m << '\n';  // 3.14

  // Constant Expressions With constexpr
  // constexpr <type> <name> = <value>;
  constexpr int32_t n = 4;
  std::cout << n << '\n';  // 4
  constexpr int32_t o = foo(5);
  std::cout << o << '\n';  // 10
  // int32_t x = 6;
  // constexpr int32_t p = foo(x); // Error: Read of non-const variable 'x' is
  // not allowed in a constant expression

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- const:
  - const is a keyword that declares a constant.
  - Constants are variables that cannot be changed after initialization.
  - The initial value can be dynamic (set at runtime).
  - Warning: always declare variables as const if they are not meant to be
changed. It will help you avoid bugs, understand your code better, and improve
performance.
- Type Aliases:
  - Type aliases are a way to create a new name for an existing type.
  - Warning: avoid using typedef. It is an old way of creating type aliases
(C++98). Use using instead (C++11).
- Type Deduction:
  - Type deduction is a way to let the compiler deduce the type of a variable
from the right-hand side of the assignment.
  - It is often more convenient, safer, and future proof.
  - It is also important for generic (type independent) programming.
- Constant Expressions:
  - Constant expressions are expressions that can be evaluated at compile time.
  - They can be computed at runtime if not invoked in a constexpr context.
  - All expressions inside a constexpr context must be constexpr themselves.
  - constexpr functions may contain:
    - nothing but one return statement (C++11).
    - multiple statements (C++14).
*/
