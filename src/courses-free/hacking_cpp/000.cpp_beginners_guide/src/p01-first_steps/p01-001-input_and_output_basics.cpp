#include <iostream>

int main() {
  int i{};
  std::cout << "Enter an integer: ";
  std::cin >> i;  // read value into i. Reads from buffer.
  std::cout << "Your integer is: " << i << '\n';  // print value of i. It writes
                                                  // to buffer first and then to
                                                  // console when buffer is
                                                  // full.
  std::clog << "Your integer is: " << i << '\n';  // print value of i to the
                                                  // log. It writes to buffer
                                                  // first and then to console
                                                  // when buffer is full.
  std::cerr << "Your integer is: " << i << '\n';  // print value of i to the
                                                  // error log. It immediately
                                                  // writes to console.
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Stream Operators:
  - <<: output stream operator.
  - >>: input stream operator. It reads until the next whitespace character is
found (space, newline, tab, etc).
  - It works for fundamental types (int, float, double, char, bool, etc.) and
for strings.
  - They can be chained together.
- Avoid std::endl because it flushes the buffer immediately, leading to serious
performance degradation if done frequently. It's better to use '\n' instead.
*/
