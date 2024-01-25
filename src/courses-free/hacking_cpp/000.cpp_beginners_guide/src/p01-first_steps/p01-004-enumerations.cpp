#include <cstdint>
#include <iostream>

// Scoped enumeration: each enumerator is mapped to a whole number from 0 to
// N-1. They are confined to a named scope. We can't query properties of the
// enum.
enum class Day {
  MONDAY,
  TUESDAY,
  WEDNESDAY,
  THURSDAY,
  FRIDAY,
  SATURDAY,
  SUNDAY
};

// Unscoped enumeration: each enumerator is mapped to a whole number from 0 to
// N-1. They are not confined to a named scope (name collisions). We can't query
// properties of the enum. It's dangerous to do implicit conversions from an
// enum to an underlying type. Avoid using them.
enum Color { RED, BLUE, GREEN };
// enum Color2 { RED, BLUE, GREEN };  // Error: Redefinition of enumerator

// Underlying Type Of Enumerations: they must be an integer type (char, short,
// long, …). Int is the default.
// Custom enumerator mapping: the enumerator values can be set explicitly. They
// don't need to start with 0 or be consecutive.
enum class LanguageIso639 : int16_t { EN = 1, FR = 2, DE = 3 };

int main() {
  // Scoped enumeration
  Day today = Day::TUESDAY;
  std::cout << "Today is " << static_cast<int>(today) << std::endl;

  // Unscoped enumeration
  Color color = RED;
  std::cout << "Color is " << color << std::endl;

  // Underlying Type Of Enumerations and Custom enumerator mapping
  LanguageIso639 lang = LanguageIso639::EN;
  std::cout << "Language is " << static_cast<int16_t>(lang) << std::endl;

  // Converting from an enum to an underlying type
  auto lang_int16 = static_cast<int16_t>(lang);
  std::cout << "Language is " << lang_int16 << std::endl;

  // Converting from an underlying type to an enum
  lang = static_cast<LanguageIso639>(lang_int16);
  std::cout << "Language is " << static_cast<int16_t>(lang) << std::endl;

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Warning: It is better to use scoped enumerations. They are safer and more
expressive.
- It is possible to change the underlying type of a scoped enumeration. And
the mapping of the enumerators can be customized.
- It is not easy to print the actual values (int text format) of scoped
enumerations. We would need to use a map or a switch statement or maybe a macro.
*/
