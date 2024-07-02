#ifndef VALID_PARENTHESES_SOLUTION_CPP_HPP
#define VALID_PARENTHESES_SOLUTION_CPP_HPP

#include <cstdint>
#include <iostream>
#include <string>
#include "leetcode/cpp_template/template_cpp.hpp"

namespace valid_parentheses {
struct InputValues {
  /**
   * @brief a string containing just the characters '(', ')', '{', '}', '['
   * and ']'
   */
  std::string s{};

  friend std::ostream& operator<<(std::ostream& os,
                                  const InputValues& input_values) {
    os << "s: " << input_values.s;
    return os;
  }
};

struct OutputValues {
  /**
   * @brief true if the input string is valid. This means open brackets must
   * be closed by the same type of brackets, and open brackets must be closed in
   * the correct order.
   */
  bool is_valid{};

  explicit OutputValues(bool is_valid) : is_valid(is_valid) {}

  friend std::ostream& operator<<(std::ostream& os,
                                  const OutputValues& output_values) {
    os << "is_valid: " << std::boolalpha << output_values.is_valid;
    return os;
  }
};

class SolutionCppV1 : public leetcode::SolutionCpp {

 public:
  /*
   * time complexity:
   * space complexity:
   */
  OutputValues do_something(InputValues /**/) override;
};

class SolutionCppV2 : public leetcode::SolutionCpp {

 public:
  /*
   * time complexity:
   * space complexity:
   */
  OutputValues is_valid(InputValues /**/) override;
};

}  // namespace valid_parentheses

#endif  // VALID_PARENTHESES_SOLUTION_CPP_HPP
