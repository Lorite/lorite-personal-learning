#include <glog/logging.h>
#include <gtest/gtest.h>
#include "hello-lib.hpp"

// Demonstrate some basic assertions.
TEST(STDFindTest, BasicAssertions) {
  // Expect two strings not to be equal.
  EXPECT_STRNE("hello", "world");
  // Expect equality.
  EXPECT_EQ(7 * 6, 42);
}

TEST(HelloLibTest, Greet) {
  hello::HelloLib lib("Hello");
  std::string thing = "world";
  lib.greet(thing);
}

int main(int argc, char** argv) {
  ::testing::InitGoogleTest(&argc, argv);
  google::InitGoogleLogging(argv[0]);
  return RUN_ALL_TESTS();
}
