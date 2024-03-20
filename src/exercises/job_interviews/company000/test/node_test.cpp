#include "node.hpp"
#include <gmock/gmock.h>
#include <gtest/gtest.h>
#include <memory>

class NodeTestFixture : public ::testing::Test {
 protected:
  void SetUp() override {
    node = std::make_unique<company000_exercise_1::Node>(33);
  }

  void TearDown() override {}

 public:
  std::unique_ptr<company000_exercise_1::Node> node;
};

TEST_F(NodeTestFixture, NodeCanBeCreatedWithAValue) {
  ASSERT_NE(node.get(), nullptr);
  ASSERT_EQ(node->get_value(), 33);
  ASSERT_EQ(node->get_children().size(), 0);
}

TEST_F(NodeTestFixture, NodeCanBePrinted) {
  std::stringstream ss;
  ss << *node;
  ASSERT_THAT(ss.str(), testing::HasSubstr("Node:"));
  ASSERT_THAT(ss.str(), testing::HasSubstr("\n\tPointer: 0x"));
  ASSERT_THAT(ss.str(), testing::HasSubstr("\n\tValue: 33"));
  ASSERT_THAT(ss.str(), testing::HasSubstr("\n\tChildren pointers: "));
}

TEST_F(NodeTestFixture, NodeCanBeAddedChildren) {
  auto child1 = std::make_shared<company000_exercise_1::Node>(44);
  auto child2 = std::make_shared<company000_exercise_1::Node>(55);
  node->add_child(child1);
  node->add_child(child2);
  ASSERT_EQ(node->get_value(), 33);
  ASSERT_EQ(node->get_children().size(), 2);
  ASSERT_EQ(node->get_children().at(0)->get_value(), 44);
  ASSERT_EQ(node->get_children().at(1)->get_value(), 55);
}

TEST_F(NodeTestFixture, NodeCanBeCheckedForEvenness) {
  ASSERT_FALSE(node->is_even());
  node = std::make_unique<company000_exercise_1::Node>(44);
  ASSERT_TRUE(node->is_even());
}

int main(int argc, char** argv) {
  ::testing::InitGoogleTest(&argc, argv);
  return RUN_ALL_TESTS();
}
