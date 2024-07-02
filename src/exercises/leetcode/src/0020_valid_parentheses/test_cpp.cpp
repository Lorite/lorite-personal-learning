#include <gtest/gtest.h>
#include <algorithm>
#include <ios>
#include <memory>
#include <string>
#include <tuple>
#include <vector>
#include "solution_cpp.hpp"

namespace valid_parentheses {

TEST_P(leetcode::CppTestSuite<InputValues, OutputValues>, AssertOutputIsEqual) {
  ASSERT_EQ(input_result.is_valid, expected_values.is_valid);
}

INSTANTIATE_TEST_SUITE_P(
    ValidParenthesesTestInstantiation,
    leetcode::CppTestSuite<InputValues, OutputValues>,
    testing::Combine(
        testing::ValuesIn(std::vector<std::shared_ptr<SolutionCpp>>{
            std::make_shared<SolutionCppV1>(),
            std::make_shared<SolutionCppV2>()}),
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
}  // namespace valid_parentheses
