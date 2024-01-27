#include <array>
#include <iostream>

int main() {
  // Conditional branching
  if (true) {
    std::cout << "This is true" << std::endl;  // runs
  } else {
    std::cout << "This is false" << std::endl;  // doesn't run
  }
  // from C++17 onwards, we can use if with initializer
  if (int x = -5; x > 0) {
    std::cout << "x = " << x << " is positive" << std::endl;  // runs
  } else {
    std::cout << "x = " << x << " is negative" << std::endl;  // doesn't run
  }

  // Switching: value-based branching
  int x = -2;
  switch (x) {  // switch only works with integral types (int, char, enum, etc.)
    case 1:     // case labels must be constant expressions
      std::cout << "x is " << x << std::endl;
      break;  // break is needed to avoid fall-through
    case 2:
    case 3:  // multiple cases can be grouped
      std::cout << "x actually is " << x << std::endl;
      break;
    default:
      std::cout << "x = " << x << std::endl;
      break;
  }
  // from C++17 onwards, we can use switch with initializer
  switch (int x = 2; x) {
    case 1:
      std::cout << "x is " << x << std::endl;
      break;
    case 2:
    case 3:
      std::cout << "x actually is " << x << std::endl;
      break;
    default:
      std::cout << "x = " << x << std::endl;
      break;
  }

  // Ternary Conditional Operator
  // condition ? expression1 : expression2
  // if condition is true, expression1 is evaluated, otherwise expression2 is
  // evaluated
  auto y = (x > 0) ? x : -x;  // y = |x|. Also, see how x = 2 because of the
                              // scope of the previous switch statement
  std::cout << "y = " << y << std::endl;

  // Loop Iteration
  const std::string_view delimiter = ", ";  // C++17
  // while loop
  int i = 0;
  while (i < 10) {
    std::cout << "i = " << i << delimiter;
    ++i;
  }
  std::cout << std::endl;
  // do-while loop
  do {
    std::cout << "i = " << i << delimiter;
    ++i;
  } while (i < 20);
  std::cout << std::endl;
  // for loop
  for (int i = 0; i < 10; ++i) {
    std::cout << "i = " << i << delimiter;
  }
  std::cout << std::endl;
  // range-based for loop (C++11)
  std::array<int, 5> arr{1, 2, 3, 4, 5};
  for (int x : arr) {
    std::cout << "x = " << x << delimiter;
  }
  std::cout << std::endl;
  // break and continue
  for (int i = 0; i < 10; ++i) {
    if (i == 5) {
      continue;  // skip the rest of the loop body and go to the next iteration
    }
    if (i == 8) {
      break;  // exit the loop
    }
    std::cout << "i = " << i << delimiter;
  }
  std::cout << std::endl;

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Terminology:
  - Expressions: series of computations (operators + operands) that may produce
a result.
  - Statements: program fragments that are evaluated in sequence that do not
produce a result. They can contain one or multiple expressions. They are
delimited by a semicolon and grouped by curly braces {}.
- Only write loops if there is no (standard) library function/algorithm for what
you want to do (we will learn about the standard library in later chapters)!
- Prefer range-based loops over all other types of loops! (no indexing/condition
bugs possible)
- Use (do) while loops only, if the number of iterations is not known
beforehand!
*/
