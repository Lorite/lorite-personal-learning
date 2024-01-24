#include <bitset>
#include <compare>
#include <iostream>
#include <limits>

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
  unsigned long long ll2{10};  // declare and initialize variable ll2 with
                               // value 10.
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
  // type new_value = value operator value2 operator value3; // operations can
  // be chained type new_value operator= value; // this is a compound assignment
  // operator
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
  // 2-way comparisons
  int x{1};
  int y{4};
  bool b4{x == y};  // equal to
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b4 = x == y = " << b4 << '\n';
  bool b5{x != y};  // not equal to
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b5 = x != y = " << b5 << '\n';
  bool b6{x < y};  // less than
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b6 = x < y = " << b6 << '\n';
  bool b7{x > y};  // greater than
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b7 = x > y = " << b7 << '\n';
  bool b8{x <= y};  // less than or equal to
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b8 = x <= y = " << b8 << '\n';
  bool b9{x >= y};  // greater than or equal to
  std::cout << "x = " << x << ',' << " y = " << y << ','
            << " b8 = x >= y = " << b9 << '\n';
  // 3-way comparisons (C++20)
  std::strong_ordering so{x <=> y};  // spaceship operator. It compares with 0.
  std::cout << "x = " << x << ',' << " y = " << y << ',' << " so = x <=> y = "
            << "x"
            << (so < 0   ? " <  "
                : so > 0 ? " >  "
                         : " == ")  // compares with 0
            << "y" << '\n';

  // Boolean logic
  // Operators
  bool b10{true};
  bool b11{false};
  bool b12{b10 && b11};  // logical AND
  std::cout << "b10 = " << b10 << ',' << " b11 = " << b11 << ','
            << " b12 = b10 && b11 = " << b12 << '\n';
  bool b13{b10 || b11};  // logical OR
  std::cout << "b10 = " << b10 << ',' << " b11 = " << b11 << ','
            << " b13 = b10 || b11 = " << b13 << '\n';
  bool b14{!b10};  // logical NOT
  std::cout << "b10 = " << b10 << ',' << " b14 = !b10 = " << b14 << '\n';
  // Alternative spellings
  bool b15{b10 and b11};  // logical AND
  std::cout << "b10 = " << b10 << ',' << " b11 = " << b11 << ','
            << " b15 = b10 and b11 = " << b15 << '\n';
  bool b16{b10 or b11};  // logical OR
  std::cout << "b10 = " << b10 << ',' << " b11 = " << b11 << ','
            << " b16 = b10 or b11 = " << b16 << '\n';
  bool b17{not b10};  // logical NOT
  std::cout << "b10 = " << b10 << ',' << " b17 = not b10 = " << b17 << '\n';
  // Conversion to bool
  int i3{1};
  bool b18{static_cast<bool>(i3)};  // true
  std::cout << "i3 = " << i3 << ',' << " b18 = static_cast<bool>(i3) = " << b18
            << '\n';
  int i4{0};
  bool b19{static_cast<bool>(i4)};  // false
  std::cout << "i4 = " << i4 << ',' << " b19 = static_cast<bool>(i4) = " << b19
            << '\n';
  int i5{12};
  bool b20{static_cast<bool>(i5)};  // true
  std::cout << "i5 = " << i5 << ',' << " b20 = static_cast<bool>(i5) = " << b20
            << '\n';
  // Short-circuit evaluation
  bool b21{true};
  bool b22{false};
  bool b23{b21 && b22};  // b22 is not evaluated
  std::cout << "b21 = " << b21 << ',' << " b22 = " << b22 << ','
            << " b23 = b21 && b22 = " << b23 << '\n';

  // Memory Sizes of Fundamental Types
  // Type	Size (bytes). They are compiler/platform dependent.
  std::cout << "size of bool: " << sizeof(bool) << " byte(s)\n";    // 1 byte
  std::cout << "size of char: " << sizeof(char) << " byte(s)\n";    // 1 byte
  std::cout << "size of int: " << sizeof(int) << " byte(s)\n";      // 4 bytes
  std::cout << "size of short: " << sizeof(short) << " byte(s)\n";  // 2 bytes
  std::cout << "size of long: " << sizeof(long) << " byte(s)\n";    // 4 bytes
  std::cout << "size of long long: " << sizeof(long long)
            << " byte(s)\n";                                          // 8 bytes
  std::cout << "size of float: " << sizeof(float) << " byte(s)\n";    // 4 bytes
  std::cout << "size of double: " << sizeof(double) << " byte(s)\n";  // 8 bytes
  std::cout << "size of long double: " << sizeof(long double)
            << " byte(s)\n";  // 16 bytes
  std::cout << "size of nullptr: " << sizeof(nullptr) << " byte(s)\n";  // 8
                                                                        // bytes
  // Integer Size Guarantees (C++11)
  // Exact size (not available on some platforms)
  std::cout << "size of int8_t: " << sizeof(int8_t) << " byte(s)\n";      // 1
  std::cout << "size of uint8_t: " << sizeof(uint8_t) << " byte(s)\n";    // 1
  std::cout << "size of int16_t: " << sizeof(int16_t) << " byte(s)\n";    // 2
  std::cout << "size of uint16_t: " << sizeof(uint16_t) << " byte(s)\n";  // 2
  std::cout << "size of int32_t: " << sizeof(int32_t) << " byte(s)\n";    // 4
  std::cout << "size of uint32_t: " << sizeof(uint32_t) << " byte(s)\n";  // 4
  std::cout << "size of int64_t: " << sizeof(int64_t) << " byte(s)\n";    // 8
  std::cout << "size of uint64_t: " << sizeof(uint64_t) << " byte(s)\n";  // 8
  // Guaranteed minimum size
  std::cout << "size of int_least8_t: " << sizeof(int_least8_t)
            << " byte(s)\n";  // 1
  std::cout << "size of uint_least8_t: " << sizeof(uint_least8_t)
            << " byte(s)\n";  // 1
  std::cout << "size of int_least16_t: " << sizeof(int_least16_t)
            << " byte(s)\n";  // 2
  std::cout << "size of uint_least16_t: " << sizeof(uint_least16_t)
            << " byte(s)\n";  // 2
  std::cout << "size of int_least32_t: " << sizeof(int_least32_t)
            << " byte(s)\n";  // 4
  std::cout << "size of uint_least32_t: " << sizeof(uint_least32_t)
            << " byte(s)\n";  // 4
  std::cout << "size of int_least64_t: " << sizeof(int_least64_t)
            << " byte(s)\n";  // 8
  std::cout << "size of uint_least64_t: " << sizeof(uint_least64_t)
            << " byte(s)\n";  // 8
  // Fastest minimum-size signed integer types
  std::cout << "size of int_fast8_t: " << sizeof(int_fast8_t)
            << " byte(s)\n";  // 1
  std::cout << "size of uint_fast8_t: " << sizeof(uint_fast8_t)
            << " byte(s)\n";  // 1
  std::cout << "size of int_fast16_t: " << sizeof(int_fast16_t)
            << " byte(s)\n";  // 2
  std::cout << "size of uint_fast16_t: " << sizeof(uint_fast16_t)
            << " byte(s)\n";  // 2
  std::cout << "size of int_fast32_t: " << sizeof(int_fast32_t)
            << " byte(s)\n";  // 4
  std::cout << "size of uint_fast32_t: " << sizeof(uint_fast32_t)
            << " byte(s)\n";  // 4
  std::cout << "size of int_fast64_t: " << sizeof(int_fast64_t)
            << " byte(s)\n";  // 8
  std::cout << "size of uint_fast64_t: " << sizeof(uint_fast64_t)
            << " byte(s)\n";  // 8

  // Fixed-width floating-point types (C++23)
  // TODO: add examples of fixed-width floating-point types when C++23 is
  // available

  // std::numeric_limits<type>. It provides the smallest and largest values for
  // <type>.
  std::cout << "min value of int: " << std::numeric_limits<int>::min() << '\n';
  std::cout << "max value of int: " << std::numeric_limits<int>::max() << '\n';
  std::cout << "digits value of int: " << std::numeric_limits<int>::digits
            << '\n';
  std::cout << "min value of unsigned int: "
            << std::numeric_limits<unsigned int>::min() << '\n';
  std::cout << "max value of unsigned int: "
            << std::numeric_limits<unsigned int>::max() << '\n';
  std::cout << "digits value of unsigned int: "
            << std::numeric_limits<unsigned int>::digits << '\n';
  std::cout << "min value of float: " << std::numeric_limits<float>::min()
            << '\n';
  std::cout << "max value of float: " << std::numeric_limits<float>::max()
            << '\n';
  std::cout << "digits value of float: " << std::numeric_limits<float>::digits
            << '\n';
  std::cout << "epsilon value of float: "
            << std::numeric_limits<float>::epsilon() << '\n';
  std::cout << "min value of double: " << std::numeric_limits<double>::min()
            << '\n';
  std::cout << "max value of double: " << std::numeric_limits<double>::max()
            << '\n';
  std::cout << "digits value of double: " << std::numeric_limits<double>::digits
            << '\n';
  std::cout << "epsilon value of double: "
            << std::numeric_limits<double>::epsilon() << '\n';
  std::cout << "denorm_min value of double: "
            << std::numeric_limits<double>::denorm_min() << '\n';
  std::cout << "infinity value of double: "
            << std::numeric_limits<double>::infinity() << '\n';

  // Type Narrowing
  double d4 = 1.1F;  // OK: double can represent all values of float
  std::cout << "d4 = " << d4 << '\n';
  int i6 = static_cast<int>(4.7);  // -Wliteral-conversion warning: double ->
                                   // int. We need to static cast it.
  std::cout << "i6 = " << i6 << '\n';
  int i7{static_cast<int>(4.7F)};  // -Wliteral-conversion warning: double ->
                                   // int. We need to static cast it.
  std::cout << "i7 = " << i7 << '\n';

  // Bitwise Operations
  // Bitwise Logic
  std::uint8_t ui1{0b00000101};
  std::bitset<sizeof(ui1) * 8> bs1{ui1};  // we need bitset for using bitwise
                                          // operations or otherwise the type
                                          // changes from uint8_t to int. It
                                          // also allows us to print the binary
                                          // representation of the value.
  std::uint8_t ui2{0b00100111};
  std::bitset<sizeof(ui2) * 8> bs2{ui2};
  auto bs3{bs1 & bs2};  // bitwise AND
  std::cout << "bs1 = " << bs1 << ',' << " bs2 = " << bs2 << ','
            << " bs3 = bs1 & bs2 = " << bs3 << '\n';
  auto bs4{bs1 | bs2};  // bitwise OR
  std::cout << "bs1 = " << bs1 << ',' << " bs2 = " << bs2 << ','
            << " bs4 = bs1 | bs2 = " << bs4 << '\n';
  auto bs5{bs1 ^ bs2};  // bitwise XOR
  std::cout << "bs1 = " << bs1 << ',' << " bs2 = " << bs2 << ','
            << " bs5 = bs1 ^ bs2 = " << bs5 << '\n';
  auto bs6{~bs1};  // bitwise NOT (one's complement)
  std::cout << "bs1 = " << bs1 << ',' << " bs6 = ~bs1 = " << bs6 << '\n';
  bool b24{ui1 % 2 == 1};  // check if it's odd by the
                           // modulus operator
  std::cout << "bs1 = " << bs1 << ',' << " b24 = ui1 % 2 == 1 = " << b24
            << '\n';
  bool b25{bs1[0]};  // check if the last bit is 0 (even) directly from the
                     // bitset
  std::cout << "bs1 = " << bs1 << ',' << " b25 = bs1[0] = " << b25 << '\n';
  bool b26{(ui1 % 2) == 0};  // check if it's even by the
                             // modulus operator
  std::cout << "bs1 = " << bs1 << ',' << " b26 = ui1 % 2 == 0 = " << b26
            << '\n';
  bool b27{!bs1[0]};  // check if the last bit is 0 (even) directly from the
                      // bitset
  std::cout << "bs1 = " << bs1 << ',' << " b27 = !bs1[0] = " << b27 << '\n';
  // Bitwise Shifts
  auto bs7{bs1 << 2};  // shift left by 2 bits
  std::cout << "bs1 = " << bs1 << ',' << " bs7 = bs1 << 2 = " << bs7 << '\n';
  auto bs8{bs1 >> 2};  // shift right by 2 bits
  std::cout << "bs1 = " << bs1 << ',' << " bs8 = bs1 >> 2 = " << bs8 << '\n';
  bs1 <<= 2;  // shift left by 2 bits
  std::cout << "bs1 = " << bs1 << ',' << " bs1 <<= 2 = " << bs1 << '\n';
  bs1 >>= 2;  // shift right by 2 bits
  std::cout << "bs1 = " << bs1 << ',' << " bs1 >>= 2 = " << bs1 << '\n';

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Fundamental Types are the basic building blocks for all complex types / data
structures like lists, hash maps, trees, graphs, …. They are the simplest types
of data available in C++. They are also called primitive types.
- Variables of fundamental types are not initialized by default. They have an
undefined value. It's a good practice to always initialize variables when they
are declared even if it uses some computational resources to avoid bugs.
- Fundamental Types:
  - bool: boolean type. It can be true or false.
  - char: character type. It can hold a single character.
  - int: integer type. It can hold a whole number.
  - short: short integer type. It can hold a whole number with a smaller range
than int.
  - long: long integer type. It can hold a whole number with a larger range than
int.
  - long long: long long integer type. It can hold a whole number with a larger
range than long.
  - unsigned <type>: unsigned integer type. It can hold a whole number with a
larger range than <type> but it can't hold negative numbers.
  - float: floating point type. It can hold a decimal number.
  - double: double precision floating point type. It can hold a decimal number
with double precision.
  - long double: long double precision floating point type. It can hold a
decimal number with long double precision.
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
  - ++variable: pre-increment. Increments the value of variable by 1 and returns
the new value.
  - variable++: post-increment. Increments the value of variable by 1 and
returns the old value.
  - --variable: pre-decrement. Decrements the value of variable by 1 and returns
the new value.
  - variable--: post-decrement. Decrements the value of variable by 1 and
returns the old value.
- Comparisons:
    - 2-way comparisons:
        - ==: equal to.
        - !=: not equal to.
        - <: less than.
        - >: greater than.
        - <=: less than or equal to.
        - >=: greater than or equal to.
    - 3-way comparisons (C++20):
        - <=>: spaceship operator. It returns -1 if the left operand is less
than the right operand, 0 if they are equal, and 1 if the left operand is
greater than the right operand. The actual return values are
std::strong_ordering::less, std::strong_ordering::equal, and
std::strong_ordering::greater.
- Boolean logic:
  - Operators:
    - && or and: logical AND.
    - || or or: logical OR.
    - ! or not: logical NOT.
  - Conversion to bool:
    - 0 is converted to false.
    - Any other value is converted to true.
  - Short-circuit evaluation:
    - The second operand of a boolean comparison is not evaluated if the result
is already known after evaluating the first operand.
- Memory Sizes of Fundamental Types:
  - Type	Size (bytes). They are compiler/platform dependent.
    - bool: 1 byte.
    - char: 1 byte.
    - int: 4 bytes.
    - short: 2 bytes.
    - long: 4 bytes.
    - long long: 8 bytes.
    - float: 4 bytes.
    - double: 8 bytes.
    - long double: 16 bytes.
    - nullptr: 8 bytes.
  - There are also fixed-width integer types that guarantee a specific size.
  - Integer Size Guarantees (C++11):
    - Exact size (not available on some platforms):
      - int8_t: 1 byte.
      - uint8_t: 1 byte.
      - int16_t: 2 bytes.
      - uint16_t: 2 bytes.
      - int32_t: 4 bytes.
      - uint32_t: 4 bytes.
      - int64_t: 8 bytes.
      - uint64_t: 8 bytes.
    - Guaranteed minimum size:
      - int_least8_t: 1 byte.
      - uint_least8_t: 1 byte.
      - int_least16_t: 2 bytes.
      - uint_least16_t: 2 bytes.
      - int_least32_t: 4 bytes.
      - uint_least32_t: 4 bytes.
      - int_least64_t: 8 bytes.
      - uint_least64_t: 8 bytes.
    - Fastest minimum-size signed integer types:
      - int_fast8_t: 1 byte.
      - uint_fast8_t: 1 byte.
      - int_fast16_t: 2 bytes.
      - uint_fast16_t: 2 bytes.
      - int_fast32_t: 4 bytes.
      - uint_fast32_t: 4 bytes.
      - int_fast64_t: 8 bytes.
      - uint_fast64_t: 8 bytes.
- std::numeric_limits<type>. It provides a standardized way to query various
properties of arithmetic types (e.g. the largest or smallest possible value for
a type.
- Type Narrowing: converting a value of a type to a value of another type:
    - conversion from type that can represent more values to one that can
represent less
    - may result in loss of information
    - in general no compiler warning – happens silently
    - potential source of subtle runtime bugs
    - narrowing conversions give a warning with -Wliteral-conversion, so
enabling warnings as errors with -Werror will prevent them
    - narrowing conversions can be avoided by using static_cast<type> to convert
the value to the desired type
- Bitwise Operations:
  - Bitwise Logic:
    - & or and: bitwise AND.
    - | or or: bitwise OR.
    - ^ or xor: bitwise XOR.
    - ~ or not: bitwise NOT (one's complement).
  - Bitwise Shifts:
    - x << n 	returns x's value with its bits shifted by n places to the left.
    - x >> n 	returns x's value with its bits shifted by n places to the
right.
    - x <<= n 	modifies x by shifting its bits by n places to the left.
    - x >>= n 	modifies x by shifting its bits by n places to the right.
    - It doesn't apply a circular shift. The bits that are shifted out of one.
    - Warning: shifting a value by more bits than it has is undefined behavior.
- Arithmetic Conversions and Promotions:
  - Unfortunately, there's a lot of rules (that go back to C) whose purpose is
to determine a common type for both operands and the result of a binary
operation.
  - The rules are:
    - Operations involving at least one floating-point type:
      long double >> double >> float
    - Operations involving only integer types:
      1st, integer promotion: everything smaller than int gets promoted to
either int or unsiged int. 2nd, integer conversion:
        - both signed: smaller type converted to larger.
        - both unsigned: smaller type converted to larger.
        - signed ⊕ unsigned:
          - signed converted to unsigned if both have same width.
          - otherwise unsigned converted to signed if that can represent all
values.
          - otherwise both converted to unsigned.
    - Check https://hackingcpp.com/cpp/lang/usual_arithmetic_conversions.png

*/
