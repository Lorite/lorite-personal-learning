#include <iostream>

auto add(auto p, auto q) {
  return p + q;
}

int main() {
  auto num1 = 10;
  auto num2 = 11;
  auto a = add(num1, num2);
  std::cout << "The sum of " << num1 << " and " << num2 << " is " << a
            << std::endl;
  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Check the `memory basics` source file for notes on the memory organisation
(heap vs stack).
-  How Function Calls Work
  - There are compiler optimizations that can change the exact mechanics of a
function call (for example inlining (replacing function calls with the function
body), return type optimization, etc.).
  - The exact order in which things are put on the stack during a function call
(the "calling convention") depends on the platform (CPU architecture + OS +
compiler).
  - Be careful with returning a reference to a local variable (or a pointer to a
local variable) from a function. The local variable will be destroyed when the
function returns, and the reference (or pointer) will be invalid.
- Common Compiler Optimizations:
  - Return Value Optimization (RVO): No extra placeholder for the return value
is allocated, no copy takes place. Instead, the external object res is directly
constructed at the call site. Guaranteed since C++17.
  - Named Return Value Optimization (NRVO): Similar to RVO, but the return value
is named. Almost all modern compilers perform this optimization.
  - Inlining: Replacing a function call with the function body when they are
small/short. Inlining can only happen, if the compiler "sees" not only the
function declaration but also its full definition, which is not necessarily the
case.
*/
