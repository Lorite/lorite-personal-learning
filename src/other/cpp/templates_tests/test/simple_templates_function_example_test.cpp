#include "simple_templates_function_example.hpp"
#include <gtest/gtest.h>

TEST(TemplatesTest, TemplateFunction) {
  // Arrange + Act + Assert
  ASSERT_EQ(templates_tests::add(2, 3), 5);
  ASSERT_EQ(templates_tests::add(2.0, 3.0), 5.0);
  ASSERT_EQ(templates_tests::add(2.0f, 3.0f), 5.0f);

  // templates_tests::add("A", "B"); // This line will not compile (invalid
  // operands to binary expression ('const char *' and 'const char *'))
}

TEST(TemplatesTest, TemplateClass) {
  // Arrange
  templates_tests::MyClass<int> my_class_int(5);
  templates_tests::MyClass<float> my_class_float(5.0f);
  templates_tests::MyClass<std::string> my_class_string("string");

  // Act + Assert
  ASSERT_EQ(my_class_int.get_value(), 5);
  ASSERT_EQ(my_class_float.get_value(), 5.0f);
  ASSERT_EQ(my_class_string.get_value(), "string");
}
