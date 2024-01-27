#include <iostream>
#include <string>

int main() {
  // std::string is a dynamic array of char (similar to vector<char>).
  std::string hw = "Hello";
  std::string s = hw;  // copy of hw
  hw += " World!";     // concatenation (append)
  std::cout << hw << '\n';
  std::cout << hw[4] << '\n';        // single char access.
  std::cout << hw.length() << '\n';  // length of string.
  std::cout << hw.size() << '\n';    // size of string.

  // char
  char c1 = 'a';
  char c2 = 97;  // ASCII code for 'a'
  std::cout << "c1: " << c1 << ", c2: " << c2 << '\n';
  std::cout << "c1: " << (int)c1 << ", c2: " << (int)c2 << '\n';
  std::cout << "c1 == c2: " << (c1 == c2) << '\n';
  hw[0] = 'h';  // modify string
  std::cout << hw << '\n';
  // Special Characters
  std::cout << "Hello\nWorld!\n";  // newline
  std::cout << "Hello\tWorld!\n";  // tab
  std::cout << "Hello\bWorld!\n";  // backspace
  std::cout << "Hello\rWorld!\n";  // carriage return
  std::cout << "Hello\fWorld!\n";  // form feed
  std::cout << "Hello\aWorld!\n";  // bell
  std::cout << "Hello\\World!\n";  // backslash
  std::cout << "Hello\'World!\n";  // single quote
  std::cout << "Hello\"World!\n";  // double quote
  std::cout << "Hello\?World!\n";  // question mark
  std::cout << "Hello\0World!\n";  // null character

  // String Manipulation
  std::string s1 = "I like pizza";
  std::cout << "s1: " << s1 << '\n';
  s1.insert(7, "cheese ");  // insert at index 7
  std::cout << "insert: " << s1 << '\n';
  s1.erase(6, 7);  // erase 7 chars at index 6
  std::cout << "erase: " << s1 << '\n';
  s1.replace(7, 5, "burgers");  // replace 5 chars at index 7
  std::cout << "replace: " << s1 << '\n';
  s1.resize(7);  // resize to 7 chars
  std::cout << "resize: " << s1 << '\n';
  s1.resize(20, 'm');  // resize to 20 chars, fill with 'x'
  std::cout << "resize: " << s1 << '\n';
  // find
  std::cout << "find m: " << s1.find('m') << '\n';      // first occurrence from
                                                        // the beginning (left)
  std::cout << "find yes: " << s1.find("yes") << '\n';  // not found: npos. npos
                                                        // is a static member
                                                        // constant value with
                                                        // the greatest possible
                                                        // value for an element
                                                        // of type size_t.
  std::cout << "rfind m: " << s1.rfind('m') << '\n';    // first occurrence from
                                                        // the end (right)
  std::cout << "find m from index 10: " << s1.find('m', 10) << '\n';  // first
  // occurrence
  // from
  // index
  // 10
  std::cout << "substr: " << s1.substr(7, 3) << '\n';  // substring from index 7
                                                       // with length 3
  std::cout << "contains pizza: " << (s1.find("pizza") != std::string::npos)
            << '\n';  // contains pizza? string.contains is C++23
  std::cout << "ends with pizza: " << (s1.ends_with("pizza")) << '\n';  // ends
  // with
  // pizza?
  // C++20
  std::cout << "starts with I: " << (s1.starts_with("I")) << '\n';  // starts
                                                                    // with I?
                                                                    // C++20

  // Literals
  auto s2 = "Hello World!";  // const char*
  std::cout << "s2: " << s2 << '\n';

  using namespace std::string_literals;  // std::string (C++14)
  auto s3 = "Hello World"s;  // std::string. Notice the 's' at the end.
  std::cout << "s3: " << s3 << '\n';
  auto s4 = "Hello "s + "World"s;  // std::string
  std::cout << "s4: " << s4 << '\n';
  auto s5 =
      "Hello"
      "world"
      "!"s;  // std::string
  std::cout << "s5: " << s5 << '\n';
  auto s6 = R"(Hello "World"!)";  // raw string literal
  std::cout << "s6: " << s6 << '\n';

  // String-Like Function parameters
  // std::string_view (C++17)
  std::string_view sv1 = "Hello World!";
  std::cout << "sv1: " << sv1 << '\n';
  // sv1[1] = 'a';  // error: std::string_view is immutable (const)

  std::cout << "Input a string: ";
  std::string s7{};
  std::getline(std::cin, s7);  // read a line from std::cin into s1
  std::cout << "s7: " << s7 << '\n';
  std::cout << "Input a string with a space: ";
  std::getline(std::cin, s7, ' ');  // read until space
  std::cout << "s7: " << s7 << '\n';

  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- std::string:
  - dynamic array of char (similar to vector<char>).
  - concatenation with + or +=.
  - single character access with [index].
  - modifiable ("mutable") unlike in e.g., Python or Java.
  - regular: deeply copyable, deeply comparable.
- char:
  - one char can hold a single character.
  - smallest integer type (usually 1 byte).
  - char literals must be enclosed in single quotes: 'a', 'b', 'c', ….
- Special Characters:
  - \n: newline.
  - \t: tab.
  - \b: backspace.
  - \r: carriage return.
  - \f: form feed.
  - \a: bell.
  - \\: backslash.
  - \': single quote.
  - \": double quote.
  - \?: question mark.
  - \0: null character.
- String Manipulation:
  - insert: insert at index.
  - erase: erase at index.
  - replace: replace at index.
  - resize: resize to length.
  - find: find first occurrence from the beginning (left).
  - rfind: find first occurrence from the end (right).
  - substr: substring from index with length.
  - contains: contains substring? (C++23).
  - ends_with: ends with substring? (C++20).
  - starts_with: starts with substring? (C++20).
- Literals:
  - requires `using namespace std::string_literals;`.
  - std::string (C++14) with 's' suffix.
  - raw string literal with R"(...)". Syntax:
R"delimiter(characters...)delimiter)".
- String-Like Function parameters:
  - std::string_view (C++17):
    - lightweight (= cheap to copy, can be passed by value).
    - non-owning (= not responsible for allocating or deleting memory).
    - read-only view (= does not allow modification of target string).
    - of a string(-like) object (std::string / "literal" / …).
    - primary use case: read-only function parameters.
    - avoids expensive temporary strings when string literals are passed to
functions.
    - can speed up accesses by avoiding a level of indirection.
- When to use what: if you...
  - always need a copy of the input string inside the function -> std::string.
  - want read-only access -> std::string_view or const std::string&.
  - want to modify the input string -> std::string&.
*/
