#include "solution_cpp.hpp"
#include <cstddef>
#include <cstdint>
#include <iostream>
#include <stack>
#include <string>
#include <vector>

namespace valid_parentheses {

bool SolutionCppV1::is_valid(std::string s) {
  std::vector<char> remaining_chars{};
  for (auto c : s) {
    if (c == '(' || c == '{' || c == '[') {
      remaining_chars.push_back(c);
    } else {
      if (remaining_chars.empty()) {
        return false;
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
        return false;
      }
    }
  }
  return remaining_chars.empty();
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
