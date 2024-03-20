#include "path.hpp"
#include <gtest/gtest.h>
#include <memory>

class PathTestFixture : public ::testing::Test {
 protected:
  void SetUp() override {}

  void TearDown() override {}

 public:
  std::unique_ptr<company000_exercise_1::Path> path;
};

TEST_F(PathTestFixture, PathCanBeCreatedFromVectorOfZeroNodes) {
  auto nodes = std::vector<std::shared_ptr<company000_exercise_1::Node>>{};
  ASSERT_NO_THROW(path = std::make_unique<company000_exercise_1::Path>(nodes));
  ASSERT_NE(path.get(), nullptr);
}

TEST_F(PathTestFixture, PathCanBeCreatedFromVectorOfNodes) {
  auto node1 = std::make_shared<company000_exercise_1::Node>(1);
  auto node2 = std::make_shared<company000_exercise_1::Node>(2);
  auto node3 = std::make_shared<company000_exercise_1::Node>(3);
  auto nodes = std::vector<std::shared_ptr<company000_exercise_1::Node>>{
      node1, node2, node3};
  ASSERT_NO_THROW(path = std::make_unique<company000_exercise_1::Path>(nodes));
  ASSERT_NE(path.get(), nullptr);
}

TEST_F(PathTestFixture, PathCanBePrinted) {
  auto node1 = std::make_shared<company000_exercise_1::Node>(1);
  auto node2 = std::make_shared<company000_exercise_1::Node>(2);
  auto node3 = std::make_shared<company000_exercise_1::Node>(3);
  auto nodes = std::vector<std::shared_ptr<company000_exercise_1::Node>>{
      node1, node2, node3};
  path = std::make_unique<company000_exercise_1::Path>(nodes);
  std::stringstream ss;
  ss << *path;
  ASSERT_EQ(ss.str(), "Path:\n\tTotal value: 6\n\tNodes: 1 -> 2 -> 3\n");
}

int main(int argc, char** argv) {
  google::InitGoogleLogging(argv[0]);
  ::testing::InitGoogleTest(&argc, argv);
  return RUN_ALL_TESTS();
}
