#include <gtest/gtest.h>
#include <tuple>
#include <vector>
#include "solution_cpp.hpp"

struct InputValues {
  std::vector<int> nums;
  int target;
};

struct ExpectedValues {
  std::vector<int> indices;
};

class TwoSumTestSuite
    : public testing::TestWithParam<std::tuple<InputValues, ExpectedValues>> {
 protected:
  void SetUp() override {
    input_values = std::get<InputValues>(GetParam());
    expected_values = std::get<ExpectedValues>(GetParam());
  }

  void TearDown() override {}

  two_sum::SolutionCpp solution{};
  InputValues input_values{};
  ExpectedValues expected_values{};
};

TEST_P(TwoSumTestSuite, CompleteTest) {
  auto input_result = solution.two_sum(input_values.nums, input_values.target);
  ASSERT_EQ(solution.two_sum(input_values.nums, input_values.target).size(),
            expected_values.indices.size())
      << "Vectors are of unequal length. Expected: "
      << expected_values.indices.size()
      << " elements, but got: " << input_result.size() << " elements.";
  for (size_t i = 0; i < expected_values.indices.size(); ++i) {
    EXPECT_EQ(solution.two_sum(input_values.nums, input_values.target)[i],
              expected_values.indices[i])
        << "Vectors differ at index " << i << ".";
  }
}

INSTANTIATE_TEST_SUITE_P(
    TwoSumTestInstantiation, TwoSumTestSuite,
    testing::Values(std::tuple<InputValues, ExpectedValues>(
        InputValues{{2, 7, 11, 15}, 0}, ExpectedValues{{}})));
