#ifndef VALID_PARENTHESES_SOLUTION_CPP_HPP
#define VALID_PARENTHESES_SOLUTION_CPP_HPP

#include <cstdint>
#include <iostream>
#include <string>

namespace valid_parentheses {
class SolutionCpp {
 public:
  /*
   * @param s: a string containing just the characters '(', ')', '{', '}', '['
   * and ']'
   * @return: true if the input string is valid. This means open brackets must
   * be closed by the same type of brackets, and open brackets must be closed in
   * the correct order.
   */
  virtual bool is_valid(std::string s) = 0;

  /*
   * @brief virtual destructor
   */
  virtual ~SolutionCpp() = default;

 protected:
  friend std::ostream& operator<<(std::ostream& os,
                                  const SolutionCpp& solution_cpp) {
    os << typeid(solution_cpp).name();
    return os;
  }
};

class SolutionCppV1 : public SolutionCpp {

 public:
  /*
   * time complexity:
   * space complexity:
   */
  bool is_valid(std::string s) override;
};

class SolutionCppV2 : public SolutionCpp {

 public:
  /*
   * time complexity:
   * space complexity:
   */
  bool is_valid(std::string s) override;
};

}  // namespace valid_parentheses

#endif  // VALID_PARENTHESES_SOLUTION_CPP_HPP
