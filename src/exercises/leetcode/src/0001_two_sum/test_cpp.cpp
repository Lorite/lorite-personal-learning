#include <gtest/gtest.h>
#include <algorithm>
#include <memory>
#include <tuple>
#include <vector>
#include "solution_cpp.hpp"

struct InputValues {
  std::vector<int> nums;
  int target;
};

struct OutputValues {
  std::vector<int> indices;
};

class TwoSumTestSuite : public testing::TestWithParam<
                            std::tuple<std::shared_ptr<two_sum::SolutionCpp>,
                                       std::tuple<InputValues, OutputValues>>> {
 protected:
  void SetUp() override {
    solution_cpp = std::get<0>(GetParam());
    auto values = std::get<1>(GetParam());
    input_values = std::get<InputValues>(values);
    expected_values = std::get<OutputValues>(values);

    input_result.indices =
        solution_cpp->two_sum(input_values.nums, input_values.target);
  }

  void TearDown() override {
    input_values = {};
    input_result = {};
    expected_values = {};
    solution_cpp.reset();
  }

  std::shared_ptr<two_sum::SolutionCpp> solution_cpp;
  InputValues input_values{};
  OutputValues input_result{};
  OutputValues expected_values{};
};

TEST_P(TwoSumTestSuite, AssertVectorsAreEqual) {
  ASSERT_EQ(input_result.indices.size(), expected_values.indices.size())
      << "Vectors are of unequal length. Expected: "
      << expected_values.indices.size()
      << " elements, but got: " << input_result.indices.size() << " elements.";

  std::sort(input_result.indices.begin(), input_result.indices.end());
  std::sort(expected_values.indices.begin(), expected_values.indices.end());
  for (size_t i = 0; i < expected_values.indices.size(); ++i) {
    EXPECT_EQ(input_result.indices.at(i), expected_values.indices.at(i))
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
        testing::ValuesIn(std::vector<std::tuple<InputValues, OutputValues>>{
            std::tuple<InputValues, OutputValues>(
                InputValues{{2, 7, 11, 15}, 9}, OutputValues{{0, 1}}),
            std::tuple<InputValues, OutputValues>(InputValues{{3, 2, 4}, 6},
                                                  OutputValues{{1, 2}}),
            std::tuple<InputValues, OutputValues>(InputValues{{3, 3}, 6},
                                                  OutputValues{{0, 1}})})));
