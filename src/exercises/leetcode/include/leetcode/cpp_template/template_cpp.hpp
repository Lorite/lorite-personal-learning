#ifndef TEMPLATE_SOLUTION_CPP_HPP
#define TEMPLATE_SOLUTION_CPP_HPP

#include <gtest/gtest.h>
#include <memory>

namespace leetcode {
template <typename InputValues, typename OutputValues>
class SolutionCpp {
 public:
  /**
   * @brief pure virtual function to be implemented by derived classes.
   */
  virtual OutputValues do_something(InputValues) = 0;

  /**
   * @brief virtual destructor
   */
  virtual ~SolutionCpp() = default;
};

template <typename InputValues, typename OutputValues>
class CppTestSuite
    : public testing::TestWithParam<
          std::tuple<std::shared_ptr<SolutionCpp<InputValues, OutputValues>>,
                     std::tuple<InputValues, OutputValues>>> {
 protected:
  void SetUp() override {
    solution_cpp = std::get<0>(GetParam());
    auto values = std::get<1>(GetParam());
    input_values = std::get<InputValues>(values);
    expected_values = std::get<OutputValues>(values);

    input_result = solution_cpp->do_something(input_values);
  }

  void TearDown() override {
    input_values = {};
    input_result = {};
    expected_values = {};
    solution_cpp.reset();
  }

  std::shared_ptr<SolutionCpp<InputValues, OutputValues>> solution_cpp{};
  InputValues input_values{};
  OutputValues input_result{};
  OutputValues expected_values{};
};

}  // namespace leetcode

#endif  // TEMPLATE_SOLUTION_CPP_HPP
