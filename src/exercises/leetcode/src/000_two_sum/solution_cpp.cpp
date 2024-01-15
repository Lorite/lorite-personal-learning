#include "solution_cpp.hpp"
#include <unordered_map>

namespace two_sum {

std::vector<int> SolutionCppV1::two_sum(std::vector<int>& nums, int target) {
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

std::vector<int> SolutionCppV2::two_sum(std::vector<int>& nums, int target) {
  std::unordered_map<int, int> nums_map;
  int nums_size = nums.size();
  for (int i = 0; i < nums_size; i++) {
    nums_map[nums[i]] = i;
  }
  for (int i = 0; i < nums_size; i++) {
    int complement = target - nums[i];
    if (nums_map.count(complement) && nums_map[complement] != i) {
      return {i, nums_map[complement]};
    }
  }
  return {};
}

std::vector<int> SolutionCppV3::two_sum(std::vector<int>& nums, int target) {
  std::unordered_map<int, int> nums_map;
  for (int i = 0; i < nums.size(); ++i) {
    int complement = target - nums[i];
    if (nums_map.find(complement) != nums_map.end()) {
      return {nums_map[complement], i};
    }
    nums_map[nums[i]] = i;
  }
  return {};
}

}  // namespace two_sum
