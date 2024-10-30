#include <gtest/gtest.h>

TEST(PointersTest, BasicAssertions) {
  // Arrange
  std::string* str_ptr = nullptr;
  std::string* str_ptr2 = new std::string("Hello");

  // Assert
  EXPECT_FALSE(str_ptr);
  EXPECT_TRUE(str_ptr2);
}
