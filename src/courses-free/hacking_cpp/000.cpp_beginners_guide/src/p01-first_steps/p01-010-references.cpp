#include <iostream>
#include <lorite_utils/easy_printing.hpp>
#include <vector>

using EP = lorite_utils::EasyPrinting;

/**
 * @brief Computes the median of a vector of integers.
 * @details Function with const reference parameter. We only need to read the
 * vector.
 *
 * @param v vector of integers
 * @return int median of v
 */
int median(const std::vector<int>& v) {
  return v[v.size() / 2];
}

/**
 * @brief Swaps the values of two integers.
 * @details Function with reference parameters. We want to modify the values of
 * the parameters. There's also a std::swap function in the standard library.
 *
 * @param x first integer
 * @param y second integer
 */
void swap(int& x, int& y) {
  int tmp = x;
  x = y;
  y = tmp;
}

int main() {
  // non-const References
  int x = 5;
  int& rx = x;  // rx is a reference to x
  std::cout << "x: " << x << ", rx: " << rx << '\n';
  rx = 10;  // modify x through rx
  std::cout << "x: " << x << ", rx: " << rx << '\n';
  x = 20;  // modify x
  std::cout << "x: " << x << ", rx: " << rx << '\n';

  // const References
  int y = 5;
  const int& ry = y;  // ry is a const reference to y
  std::cout << "y: " << y << ", ry: " << ry << '\n';
  // ry = 10;  // error: assignment of read-only reference 'ry'
  y = 20;  // modify y
  std::cout << "y: " << y << ", ry: " << ry << '\n';

  // auto References
  int z = 5;
  auto& rz = z;  // rz is a reference to z
  std::cout << "z: " << z << ", rz: " << rz << '\n';

  // References in Range-based for Loops
  std::vector<int> v = {1, 2, 3, 4, 5};
  std::cout << "v: " << EP::vector_to_string(v) << '\n';
  for (auto& e : v) {  // e is a reference to the current element of v
    e *= 2;
  }
  std::cout << "v after doubling all elements: " << EP::vector_to_string(v)
            << '\n';

  // const Reference Parameters
  std::cout << "median(v): " << median(v) << '\n';

  // non-const Reference Parameters
  swap(x, y);
  std::cout << "swap(x,y): x: " << x << ", y: " << y << '\n';

  // Binding Rules
  // Rvalues vs Lvalues
  int a = 1;  // a and b are both lvalues
  int b = 2;  // 1 and 2 are both rvalues
  a = b;
  b = a;
  a = a * b;      // (a * b) is an rvalue
  int c = a * b;  // OK
  // a * b = 3;       //  COMPILER ERROR: cannot assign to rvalue
  std::cout << "a: " << a << ", b: " << b << ", c: " << c << '\n';
  auto v2 = std::vector<int>(1000);  // v is an rvalue

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- non-const References:
  - references cannot be "null", i.e., they must always refer to an object.
  - a reference must always refer to the same memory location
  - reference type must agree with the type of the referenced object.
- const References:
  - value of the referenced object cannot be modified through the reference.
- auto References:
  - reference type is deduced from right hand side of assignment.
- References in Range-based for Loops:
  - range-based for loops are a convenient way to iterate over all elements of a
container.
  - the loop variable is a reference to the current element of the container.
- const Reference Parameters (in functions):
    - Avoids expensive copies.
    - Clearly communicates read-only intent to users of function.
- When to use copy / const& / &:
  - void read_from (int);  // fundamental types
  - void read_from (std::vector<int> const&);
  - void copy_sink (std::vector<int>);
  - void write_to  (std::vector<int> &);
- Warning: avoid output parameters: Functions with non-const ref parameters like
void foo (int, std::vector<int>&, double) can create confusion and
ambiguity.
- Binding Rules:
  - lvalues: expressions of which we can get memory address.
    - refer to objects that persist in memory.
    - everything that has a name (variables, function parameters, …).
  - rvalues: expressions of which we can't get memory address.
    - literals (123, "string literal", …).
    - temporary results of operations.
    - temporary objects returned from functions.
  - Reference Binding Rules:
    - &: only bind to lvalues.
    - const &: bind to lvalues and rvalues.
- Warning: never return a reference to a function-local object. The object will
be destroyed when the function returns.
- Warning: careful when referencing vector elements. References to elements of a
std::vector might be invalidated after any operation that changes the number of
elements in the vector! This is called Dangling Reference.
- Warning: avoid lifetime extension. References can extend the lifetime of
temporaries (rvalues). auto const& r = vector<int>{1,2,3,4}; --> vector exists
as long as reference r exists
- What about an object returned from a function? take it by value (recommended),
ignore it, or get const reference to it.
- Warning: don't take a reference to a member of a return value. No lifetime
extension for members of returned objects.
*/
