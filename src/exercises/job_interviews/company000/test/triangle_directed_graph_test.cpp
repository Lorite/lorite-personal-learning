#include "triangle_directed_graph.hpp"
#include <gtest/gtest.h>
#include <filesystem>
#include <path.hpp>

class TriangleDirectedGraphTestFixture : public ::testing::Test {
 protected:
  void SetUp() override {}

  void TearDown() override {}

 public:
  std::unique_ptr<company000_exercise_1::TriangleDirectedGraph>
      triangle_directed_graph;
};

TEST_F(TriangleDirectedGraphTestFixture,
       TriangleDirectedGraphCanBeCreatedFromNodesStringWithOneNode) {
  ASSERT_NO_THROW(
      triangle_directed_graph =
          std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
              std::string("1\n")));
  ASSERT_NE(triangle_directed_graph.get(), nullptr);
}

TEST_F(TriangleDirectedGraphTestFixture,
       TriangleDirectedGraphCanBeCreatedFromNodesString) {
  ASSERT_NO_THROW(
      triangle_directed_graph =
          std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
              std::string("1\n2 3\n7 8 9\n")));
  ASSERT_NE(triangle_directed_graph.get(), nullptr);
}

TEST_F(TriangleDirectedGraphTestFixture,
       TriangleDirectedGraphCantBeCreatedFromUnexistentFile) {
  ASSERT_THROW(
      triangle_directed_graph =
          std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
              std::filesystem::path("src/exercises/job_interviews/company000/"
                                    "data/unexistent_file.txt")),
      std::invalid_argument);
}

TEST_F(TriangleDirectedGraphTestFixture,
       TriangleDirectedGraphCanBeCreatedFromFile) {
  ASSERT_NO_THROW(
      triangle_directed_graph =
          std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
              std::filesystem::path("src/exercises/job_interviews/company000/"
                                    "data/simple_graph.txt")));
  ASSERT_NE(triangle_directed_graph.get(), nullptr);
}

TEST_F(TriangleDirectedGraphTestFixture, TriangleDirectedGraphCanBePrinted) {
  triangle_directed_graph =
      std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
          std::string("1\n2 3\n7 8 9\n"));
  std::stringstream ss;
  ss << *triangle_directed_graph;
  ASSERT_EQ(ss.str(),
            "1\033[0m\n2\033[0m 3\033[0m\n7\033[0m 8\033[0m 9\033[0m\n");
}

TEST_F(
    TriangleDirectedGraphTestFixture,
    TriangleDirectedGraphFindMaximumPathReturnsTheCorrectValueForAllLeftGraph) {
  triangle_directed_graph =
      std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
          std::string("1\n2 3\n7 8 9\n"));
  company000_exercise_1::Path expected_path{
      std::vector<std::shared_ptr<company000_exercise_1::Node>>{
          std::make_shared<company000_exercise_1::Node>(1),
          std::make_shared<company000_exercise_1::Node>(2),
          std::make_shared<company000_exercise_1::Node>(7)}};

  ASSERT_EQ(triangle_directed_graph->find_maximum_path()->get_total_value(),
            expected_path.get_total_value());
  for (size_t i = 0; i < expected_path.get_nodes().size(); i++) {
    ASSERT_EQ(triangle_directed_graph->find_maximum_path()
                  ->get_nodes()[i]
                  ->get_value(),
              expected_path.get_nodes()[i]->get_value());
  }
}

TEST_F(
    TriangleDirectedGraphTestFixture,
    TriangleDirectedGraphFindMaximumPathReturnsTheCorrectValueForComplexGraph) {
  triangle_directed_graph =
      std::make_unique<company000_exercise_1::TriangleDirectedGraph>(
          std::string("2\n7 9\n7 14 12\n"));
  company000_exercise_1::Path expected_path{
      std::vector<std::shared_ptr<company000_exercise_1::Node>>{
          std::make_shared<company000_exercise_1::Node>(2),
          std::make_shared<company000_exercise_1::Node>(9),
          std::make_shared<company000_exercise_1::Node>(14)}};

  ASSERT_EQ(triangle_directed_graph->find_maximum_path()->get_total_value(),
            expected_path.get_total_value());
  for (size_t i = 0; i < expected_path.get_nodes().size(); i++) {
    ASSERT_EQ(triangle_directed_graph->find_maximum_path()
                  ->get_nodes()[i]
                  ->get_value(),
              expected_path.get_nodes()[i]->get_value());
  }
}

int main(int argc, char** argv) {
  google::InitGoogleLogging(argv[0]);
  ::testing::InitGoogleTest(&argc, argv);
  return RUN_ALL_TESTS();
}
