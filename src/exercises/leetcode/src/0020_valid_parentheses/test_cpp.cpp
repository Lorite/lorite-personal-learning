#include <gtest/gtest.h>
#include <algorithm>
#include <ios>
#include <memory>
#include <string>
#include <tuple>
#include <vector>
#include "solution_cpp.hpp"

struct InputValues {
  std::string s{};

  friend std::ostream& operator<<(std::ostream& os,
                                  const InputValues& input_values) {
    os << "s: " << input_values.s;
    return os;
  }
};

struct OutputValues {
  bool is_valid{};

  friend std::ostream& operator<<(std::ostream& os,
                                  const OutputValues& output_values) {
    os << "is_valid: " << std::boolalpha << output_values.is_valid;
    return os;
  }
};

class ValidParenthesesTestSuite
    : public testing::TestWithParam<
          std::tuple<std::shared_ptr<valid_parentheses::SolutionCpp>,
                     std::tuple<InputValues, OutputValues>>> {
 protected:
  void SetUp() override {
    solution_cpp = std::get<0>(GetParam());
    auto values = std::get<1>(GetParam());
    input_values = std::get<InputValues>(values);
    expected_values = std::get<OutputValues>(values);

    input_result.is_valid = solution_cpp->is_valid(input_values.s);
  }

  void TearDown() override {
    input_values = {};
    input_result = {};
    expected_values = {};
    solution_cpp.reset();
  }

  std::shared_ptr<valid_parentheses::SolutionCpp> solution_cpp;
  InputValues input_values{};
  OutputValues input_result{};
  OutputValues expected_values{};
};

TEST_P(ValidParenthesesTestSuite, AssertOutputIsEqual) {
  ASSERT_EQ(input_result.is_valid, expected_values.is_valid);
}

INSTANTIATE_TEST_SUITE_P(
    ValidParenthesesTestInstantiation, ValidParenthesesTestSuite,
    testing::Combine(
        testing::ValuesIn(
            std::vector<std::shared_ptr<valid_parentheses::SolutionCpp>>{
                std::make_shared<valid_parentheses::SolutionCppV1>(),
                std::make_shared<valid_parentheses::SolutionCppV2>()}),
        testing::ValuesIn(std::vector<std::tuple<InputValues, OutputValues>>{
            std::tuple<InputValues, OutputValues>(InputValues{"()"},
                                                  OutputValues{true}),
            std::tuple<InputValues, OutputValues>(InputValues{"()[]{}"},
                                                  OutputValues{true}),
            std::tuple<InputValues, OutputValues>(InputValues{"(]"},
                                                  OutputValues{false}),
            std::tuple<InputValues, OutputValues>(InputValues{"([)]"},
                                                  OutputValues{false}),
            std::tuple<InputValues, OutputValues>(InputValues{"]"},
                                                  OutputValues{false})})));
