#ifndef TWO_SUM_SOLUTION_CPP_HPP
#define TWO_SUM_SOLUTION_CPP_HPP

#include <cstdint>
#include <vector>

namespace two_sum {
class SolutionCpp {
 public:
  /*
   * Time complexity: O(n^2)
   * Space complexity: O(1)
   *
   * @param nums: vector of integers
   * @param target: target sum
   * @return vector of indices of the two numbers such that they add up to
   * target
   */
  static std::vector<int> two_sum_v1(std::vector<int>& nums, int target) {
    int nums_size = nums.size();                 // IMPR1
    for (int i = 0; i < nums_size - 1; ++i) {    // it's preferred to use
                                                 // std::vector<int>::size_type
                                                 // but we have to return int
      for (int j = i + 1; j < nums_size; ++j) {  // same as above
        if (nums[i] + nums[j] == target) {  // IMPR2 (change at to [] for less
                                            // safety but more speed)
          return {i, j};
        }
      }
    }
    return {};
  }
};
}  // namespace two_sum

#endif  // TWO_SUM_SOLUTION_CPP_HPP
