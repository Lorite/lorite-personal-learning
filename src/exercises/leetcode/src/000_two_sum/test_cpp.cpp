#include <gtest/gtest.h>
#include <algorithm>
#include <memory>
#include <tuple>
#include <vector>
#include "gtest/gtest.h"
#include "solution_cpp.hpp"

struct InputValues {
  std::vector<int> nums;
  int target;
};

struct ExpectedValues {
  std::vector<int> indices;
};

class TwoSumTestSuite
    : public testing::TestWithParam<
          std::tuple<std::shared_ptr<two_sum::SolutionCpp>,
                     std::tuple<InputValues, ExpectedValues>>> {
 protected:
  void SetUp() override {
    solution_cpp = std::get<0>(GetParam());
    auto values = std::get<1>(GetParam());
    input_values = std::get<InputValues>(values);
    expected_values = std::get<ExpectedValues>(values);

    input_result =
        solution_cpp->two_sum(input_values.nums, input_values.target);
  }

  void TearDown() override {
    input_values = {};
    expected_values = {};
    input_result.clear();
    solution_cpp.reset();
  }

  std::shared_ptr<two_sum::SolutionCpp> solution_cpp;
  InputValues input_values{};
  std::vector<int> input_result{};
  ExpectedValues expected_values{};
};

TEST_P(TwoSumTestSuite, AssertVectorsAreEqual) {
  ASSERT_TRUE(true);
  ASSERT_EQ(input_result.size(), expected_values.indices.size())
      << "Vectors are of unequal length. Expected: "
      << expected_values.indices.size()
      << " elements, but got: " << input_result.size() << " elements.";

  std::sort(input_result.begin(), input_result.end());
  std::sort(expected_values.indices.begin(), expected_values.indices.end());
  for (size_t i = 0; i < expected_values.indices.size(); ++i) {
    EXPECT_EQ(input_result.at(i), expected_values.indices.at(i))
        << "Vectors differ at index " << i << ".";
  }
}

INSTANTIATE_TEST_SUITE_P(
    TwoSumTestInstantiation, TwoSumTestSuite,
    testing::Combine(
        testing::ValuesIn(std::vector<std::shared_ptr<two_sum::SolutionCpp>>{
            std::make_shared<two_sum::SolutionCppV1>(),
            std::make_shared<two_sum::SolutionCppV2>(),
            std::make_shared<two_sum::SolutionCppV3>()}),
        testing::ValuesIn(std::vector<std::tuple<InputValues, ExpectedValues>>{
            std::tuple<InputValues, ExpectedValues>(
                InputValues{{2, 7, 11, 15}, 9}, ExpectedValues{{0, 1}}),
            std::tuple<InputValues, ExpectedValues>(InputValues{{3, 2, 4}, 6},
                                                    ExpectedValues{{1, 2}}),
            std::tuple<InputValues, ExpectedValues>(InputValues{{3, 3}, 6},
                                                    ExpectedValues{{0, 1}})})));
