#ifndef TWO_SUM_SOLUTION_CPP_HPP
#define TWO_SUM_SOLUTION_CPP_HPP

#include <cstdint>
#include <vector>

namespace two_sum {
class SolutionCpp {
 public:
  /*
   * @param nums: vector of integers
   * @param target: target sum
   * @return vector of indices of the two numbers such that they add up to
   * target
   */
  virtual std::vector<int> two_sum(std::vector<int>& nums, int target) = 0;

  /*
   * @brief virtual destructor
   */
  virtual ~SolutionCpp() = default;
};

class SolutionCppV1 : public SolutionCpp {

 public:
  /*
   * time complexity: O(n^2)
   * space complexity: O(1)
   */
  std::vector<int> two_sum(std::vector<int>& nums, int target) override;
};

class SolutionCppV2 : public SolutionCpp {
 public:
  /*
   * @brief Two-Pass Hash Table
   * time complexity: O(n) + O(n) = O(n)
   * space complexity: O(n)
   */
  std::vector<int> two_sum(std::vector<int>& nums, int target) override;
};

class SolutionCppV3 : public SolutionCpp {
 public:
  /*
   * @brief One-Pass Hash Table
   * time complexity: O(n)
   * space complexity: O(n)
   */
  std::vector<int> two_sum(std::vector<int>& nums, int target) override;
};

}  // namespace two_sum

#endif  // TWO_SUM_SOLUTION_CPP_HPP
