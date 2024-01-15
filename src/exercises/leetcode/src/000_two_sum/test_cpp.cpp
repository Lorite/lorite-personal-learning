#include <gtest/gtest.h>
#include <algorithm>
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

    input_result = two_sum::SolutionCpp::two_sum_v1(input_values.nums,
                                                    input_values.target);
  }

  void TearDown() override {}

  InputValues input_values{};
  std::vector<int> input_result{};
  ExpectedValues expected_values{};
};

TEST_P(TwoSumTestSuite, AssertVectorsSizeEqual) {
  ASSERT_EQ(input_result.size(), expected_values.indices.size())
      << "Vectors are of unequal length. Expected: "
      << expected_values.indices.size()
      << " elements, but got: " << input_result.size() << " elements.";
}

TEST_P(TwoSumTestSuite, AssertVectorsElementsEqual) {
  std::sort(input_result.begin(), input_result.end());
  std::sort(expected_values.indices.begin(), expected_values.indices.end());
  for (size_t i = 0; i < expected_values.indices.size(); ++i) {
    EXPECT_EQ(input_result.at(i), expected_values.indices.at(i))
        << "Vectors differ at index " << i << ".";
  }
}

INSTANTIATE_TEST_SUITE_P(
    TwoSumTestInstantiation, TwoSumTestSuite,
    testing::Values(
        std::tuple<InputValues, ExpectedValues>(InputValues{{2, 7, 11, 15}, 9},
                                                ExpectedValues{{0, 1}}),
        std::tuple<InputValues, ExpectedValues>(InputValues{{3, 2, 4}, 6},
                                                ExpectedValues{{1, 2}}),
        std::tuple<InputValues, ExpectedValues>(InputValues{{3, 3}, 6},
                                                ExpectedValues{{0, 1}})));
