#include "solution_cpp.hpp"
#include <cstddef>
#include <cstdint>
#include <iostream>
#include <stack>
#include <string>
#include <vector>

namespace valid_parentheses {

leetcode::OutputValues SolutionCppV1::do_something(
    leetcode::InputValues input_values) {
  std::vector<char> remaining_chars{};
  for (auto c : input_values.s) {
    if (c == '(' || c == '{' || c == '[') {
      remaining_chars.push_back(c);
    } else {
      if (remaining_chars.empty()) {
        return OutputValues{false};
      } else if (c == ')' &&
                 remaining_chars.at(remaining_chars.size() - 1) == '(') {
        remaining_chars.pop_back();
      } else if (c == '}' &&
                 remaining_chars.at(remaining_chars.size() - 1) == '{') {
        remaining_chars.pop_back();
      } else if (c == ']' &&
                 remaining_chars.at(remaining_chars.size() - 1) == '[') {
        remaining_chars.pop_back();
      } else {
        return OutputValues{false};
      }
    }
  }
  return OutputValues{remaining_chars.empty()};
}

bool SolutionCppV2::is_valid(std::string s) {
  std::stack<char> remaining_chars{};  // LIFO (last-in, first-out) data
                                       // structure.
  for (auto c : s) {
    if (c == '(' || c == '{' || c == '[') {
      remaining_chars.push(c);
    } else {
      if (remaining_chars.empty() ||
          (c == ')' && remaining_chars.top() != '(') ||
          (c == '}' && remaining_chars.top() != '{') ||
          (c == ']' && remaining_chars.top() != '[')) {
        return false;
      }
      remaining_chars.pop();
    }
  }
  return remaining_chars.empty();
}

}  // namespace valid_parentheses
