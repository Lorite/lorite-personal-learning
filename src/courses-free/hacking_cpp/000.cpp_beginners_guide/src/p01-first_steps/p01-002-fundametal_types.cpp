#include <iostream>

int main() {
  // Variables declaration and initialization
  // type name = value;
  // type name{value}; // from C++11
  int i = 1;  // declare and initialize variable i with value 1.
  std::cout << "i = " << i << '\n';
  int j{2};  // declare and initialize variable j with value 2.
  std::cout << "j = " << j << '\n';

  // Fundamental types
  bool b{true};    // declare and initialize variable b with value true.
  bool b2{false};  // declare and initialize variable b2 with value false.
  std::cout << "b = " << b << ',' << " b2 = " << b2 << '\n';

  char c{97};    // declare and initialize variable c with value 'a'.
  char c2{'b'};  // declare and initialize variable c2 with value 'b'.
  std::cout << "c = " << c << ',' << " c2 = " << c2 << '\n';

  int k{3};            // declare and initialize variable k with value 3.
  unsigned int k2{4};  // declare and initialize variable k2 with value 4.
  std::cout << "k = " << k << ',' << " k2 = " << k2 << '\n';

  short s{5};            // declare and initialize variable s with value 5.
  unsigned short s2{6};  // declare and initialize variable s2 with value 6.
  std::cout << "s = " << s << ',' << " s2 = " << s2 << '\n';

  long l{7};            // declare and initialize variable l with value 7.
  unsigned long l2{8};  // declare and initialize variable l2 with value 8.
  std::cout << "l = " << l << ',' << " l2 = " << l2 << '\n';

  long long ll{9};  // declare and initialize variable ll with value 9.
  unsigned long long ll2{
      10};  // declare and initialize variable ll2 with value 10.
  std::cout << "ll = " << ll << ',' << " ll2 = " << ll2 << '\n';

  float f{11.0f};  // declare and initialize variable f with value 11.0.
  std::cout << "f = " << f << '\n';

  double d{12.0};  // declare and initialize variable d with value 12.0.
  std::cout << "d = " << d << '\n';

  long double ld{13.0};  // declare and initialize variable ld with value 13.0.
  std::cout << "ld = " << ld << '\n';

  void* p{nullptr};  // declare and initialize variable p with value nullptr.
  std::cout << "p = " << p << '\n';

  // Arithmetic operators
  // type new_value = value operator value2; // this is a binary operator
  // type new_value = value operator value2 operator value3; // operations can be chained
  // type new_value operator= value; // this is a compound assignment operator
  int a{1};
  int b3{2};
  int c3{a + b3};  // addition
  std::cout << "a = " << a << ',' << " b3 = " << b3 << ','
            << " c3 = a + b3 = " << c3 << '\n';

  int d2{c3 - a};  // subtraction
  std::cout << "c3 = " << c3 << ',' << " a = " << a << ','
            << " d2 = c3 - a = " << d2 << '\n';

  int e{d2 * c3};  // multiplication
  std::cout << "d2 = " << d2 << ',' << " c3 = " << c3 << ','
            << " e = d2 * c3 = " << e << '\n';

  int f2{e / d2};  // division
  std::cout << "e = " << e << ',' << " d2 = " << d2 << ','
            << " f2 = e / d2 = " << f2 << '\n';

  int g{f2 % d2};  // modulo (remainder of division)
  std::cout << "f2 = " << f2 << ',' << " d2 = " << d2 << ','
            << " g = f2 % d2 = " << g << '\n';

  // Increment and decrement operators
  // ++variable or variable++ or --variable or variable--
  int h{1};
  int i2{++h};  // pre-increment
  std::cout << "h = " << h << ',' << " i2 = ++h = " << i2 << '\n';

  int j2{h++};  // post-increment
  std::cout << "h = " << h << ',' << " j2 = h++ = " << j2 << '\n';

  int k3{--h};  // pre-decrement
  std::cout << "h = " << h << ',' << " k3 = --h = " << k3 << '\n';

  int l3{h--};  // post-decrement
  std::cout << "h = " << h << ',' << " l3 = h-- = " << l3 << '\n';

  // Comparisons
  // TODO
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Fundamental Types are the basic building blocks for all complex types / data structures like lists, hash maps, trees, graphs, …. They are the simplest types of data available in C++. They are also called primitive types.
- Variables of fundamental types are not initialized by default. They have an undefined value. It's a good practice to always initialize variables when they are declared even if it uses some computational resources to avoid bugs.
- Fundamental Types:
  - bool: boolean type. It can be true or false.
  - char: character type. It can hold a single character.
  - int: integer type. It can hold a whole number.
  - short: short integer type. It can hold a whole number with a smaller range than int.
  - long: long integer type. It can hold a whole number with a larger range than int.
  - long long: long long integer type. It can hold a whole number with a larger range than long.
  - unsigned <type>: unsigned integer type. It can hold a whole number with a larger range than <type> but it can't hold negative numbers.
  - float: floating point type. It can hold a decimal number.
  - double: double precision floating point type. It can hold a decimal number with double precision.
  - long double: long double precision floating point type. It can hold a decimal number with long double precision.
  - void: empty type. It can't hold any value.
- Common number representations:
  - Decimal: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9.
  - Binary: 0, 1.
  - Octal: 0, 1, 2, 3, 4, 5, 6, 7.
  - Hexadecimal: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F.
- Arithmetic operators:
  - +: addition.
  - -: subtraction.
  - *: multiplication.
  - /: division.
  - %: modulo.
- Increment and decrement operators:
  - Changes the value of a variable by 1.
  - ++variable: pre-increment. Increments the value of variable by 1 and returns the new value.
  - variable++: post-increment. Increments the value of variable by 1 and returns the old value.
  - --variable: pre-decrement. Decrements the value of variable by 1 and returns the new value.
  - variable--: post-decrement. Decrements the value of variable by 1 and returns the old value.
- Comparisons:
TODO
*/
