#include <cmath>
#include <cstdarg>
#include <iostream>

// # Inputs and Outputs

/**
 * @brief Computes the mean of two numbers.
 * @details Simple example of a function.
 *
 * @param x first number
 * @param y second number
 * @return double mean of x and y
 */
double mean(const double& x, const double& y) {
  return (x + y) / 2;
}

/**
 * @brief Computes the mean of three numbers.
 * @details Function overloading + Return type is deduced by the compiler.
 *
 * @param x first number
 * @param y second number
 * @param z third number
 * @return double mean of x, y and z
 */
auto mean(const double& x, const double& y, const double& z) {
  return (x + y + z) / 3;
}

/**
 * @brief Computes the logarithm of a number.
 * @details Function with default arguments + Return type is deduced by the
 * compiler.
 *
 * @param x number
 * @param base base of the logarithm
 * @return double logarithm of x
 */
auto logarithm(const double& x, const double& base = 10) {
  return std::log(x) / std::log(base);
}

/**
 * @brief Computes the factorial of a number.
 * @details Recursive function.
 *
 * @param n number
 * @return int factorial of n
 */
int factorial(int n) {
  if (n < 2)  // break condition
    return 1;
  return (n * factorial(n - 1));  // recursive call: n! = n * (n-1)!
}

[[nodiscard]] auto sum(const int& x, const int& y) noexcept {
  return x + y;
}

int main() {
  // Inputs and Outputs
  std::cout << "mean(2, 3) = " << mean(2, 3) << '\n';
  std::cout << "mean(2, 3, 4) = " << mean(2, 3, 4) << '\n';
  std::cout << "logarithm(100) = " << logarithm(100) << '\n';
  std::cout << "logarithm(100, 10) = " << logarithm(100, 10) << '\n';
  std::cout << "logarithm(100, 2) = " << logarithm(100, 2) << '\n';
  std::cout << "factorial(5) = " << factorial(5) << '\n';
  std::cout << "sum(2, 3) = " << sum(2, 3) << '\n';
  std::cout << "sqrt(2) = " << std::sqrt(2) << '\n';
  std::cout << "pow(2, 3) = " << std::pow(2, 3) << '\n';
  std::cout << "abs(-2) = " << std::abs(-2) << '\n';
  std::cout << "sin(2) = " << std::sin(2) << '\n';
  std::cout << "log(2) = " << std::log(2) << '\n';
  std::cout << "log10(2) = " << std::log10(2) << '\n';
  std::cout << "floor(2.5) = " << std::floor(2.5) << '\n';
  std::cout << "ceil(2.5) = " << std::ceil(2.5) << '\n';
  std::cout << "round(2.5) = " << std::round(2.5) << '\n';
  std::cout << "trunc(2.5) = " << std::trunc(2.5) << '\n';
  std::cout << "fmod(2.5, 2) = " << std::fmod(2.5, 2) << '\n';

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Functions are defined as follows:
  return_type function_name(type1 arg1, type2 arg2, ...) {
    // function body
    return return_value;
  }
- Parameters / arguments:
  - The parameters are the input arguments of the function.
  - The arguments can be none, none or many.
  - The arguments names have to be unique.
  - They are passed by value, which means that the function receives a copy of
the arguments. This is why the function cannot change the values of the
arguments passed to it.
  - We can pass arguments by reference, which means that the function receives a
  reference to the arguments. This allows the function to change the values of
  the arguments passed to it.
  - If you don't need or must not change the values of the arguments passed to a
function, pass them by const reference.
- Function body:
  - The function body is a block of code that is executed when the function is
  called.
- Return value:
  - The return type can be any type, including void (no return value).
  - From C++14, the return value can be deduced by the compiler using the
    `auto` keyword.
  - The return value is passed by value as well.
- Calling a functions:
  - Functions are called as follows: function_name(arg1, arg2, ...)
- Why to use functions:
  - Encapsulation of implementation details.
  - Easier reasoning about correctness and testing by breaking down problems
into separate functions.
  - Avoids repetition of code for common tasks.
- Overloading functions:
  - Functions can be overloaded, which means that we can have multiple functions
  with the same name but different parameters.
  - The compiler will choose the correct function to call based on the arguments
  passed to the function.
  - It cannot overload on the return type alone.
- Default arguments:
  - Functions can have default arguments, which means that the arguments can be
  omitted when calling the function.
  - The default arguments must be the last arguments of the function.
  - The default arguments must be constant expressions.
  - A call to a function with default arguments might be ambiguous if there is a
function with the same name and the same number of arguments.
- Recursion:
  - A function can call itself.
  - It needs a break condition, otherwise it will call itself indefinitely.
  - It looks more elegant than loops but in many cases slower and more complex.
  - Recursion depth is limited (by stack size).
- Declaration vs. Definition:
  - A function declaration tells the compiler about a function's name, return
  type, and parameters.
  - A function definition provides the actual body of the function.
  - A function must be declared before it is called.
  - A function can be declared many times but defined only once.
  - A function can be declared and defined in the same place.
  - A function can be declared in a header file and defined in a source file.
- Design:
  - "Interfaces should be easy to use correctly and hard to use incorrectly." -
Scott Meyers.
  - When designing a function, think about:
    - Preconditions: What do you expect/demand from input values?
    - Postconditions: What guarantees should you give regarding output values?
    - Invariants: What do callers/users of your function expect to not change?
    - Purpose: Has your function a clearly defined purpose?
    - Name: Does the function's name reflect its purpose?
    - Parameters: Can a caller/user easily confuse their meaning?
  - Precondition Checks:
    - Wide Contract Functions perform precondition checks, i.e., check input
parameter values (or program state) for validity.
    - Narrow Contract Functions do not perform precondition checks, i.e., the
caller has to make sure that input arguments (and program state) are valid.
- Attribute Specifiers:
  - Attribute specifiers are used to provide additional information about
  functions.
  - `[[noreturn]]` tells the compiler that the function does not return.
  - `[[nodiscard]]` tells the compiler that the return value of the function
  should not be discarded.
  - `[[deprecated]]` tells the compiler that the function is deprecated.
  - `[[fallthrough]]` tells the compiler that the fallthrough in a switch
  statement is intentional.
  - `[[maybe_unused]]` tells the compiler that the function might not be used.
  - `noexcept` at the end of the declaration tells the compiler that the
function does not throw exceptions (C++11).
*/
