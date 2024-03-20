#ifndef JOB_INTERVIEWS_COMPANY000_EXERCISE_1_TRIANGLE_DIRECTED_GRAPH_H_
#define JOB_INTERVIEWS_COMPANY000_EXERCISE_1_TRIANGLE_DIRECTED_GRAPH_H_

#include <glog/logging.h>
#include <cstdio>
#include <filesystem>
#include <fstream>
#include <iostream>
#include <memory>
#include <string>
#include <vector>
#include "node.hpp"
#include "path.hpp"

namespace company000_exercise_1 {

/**
 * @brief Struct that represents a file with the nodes.
 *
 */
struct NodesFile {
  std::ifstream file;
  std::string file_name;
};

/**
 * @brief Struct that represents a string with the nodes.
 *
 */
struct NodesString {
  std::string nodes;
};

/**
 * @brief TriangleDirectedGraph class. It represents a triangle directed graph
 * in the form of a pyramid. It has a vector of nodes.
 *
 */
class TriangleDirectedGraph {
 public:
  /**
   * @brief Construct a new Directed Graph object from a string of nodes.
   *
   * @param nodes_string The string of nodes. It should follow the format "1\n2
   * 3\n7 8 9", where each value is a node and each line is a level of the
   * pyramid.
   */
  explicit TriangleDirectedGraph(const std::string& nodes_string);

  /**
   * @brief Construct a new Directed Graph object from a string of nodes.
   *
   * @param file_path The file with the nodes. It should follow the format "1\n2
   * 3\n7 8 9", where each value is a node and each line is a level of the
   * pyramid.
   */
  explicit TriangleDirectedGraph(const std::filesystem::path& file_path);

  /**
   * @brief Overloaded stream insertion operator function to print the graph.
   *
   * @param os The output stream.
   * @param triangle_directed_graph The graph to be printed.
   * @return std::ostream& The output stream.
   */
  friend std::ostream& operator<<(
      std::ostream& os, TriangleDirectedGraph const& triangle_directed_graph);

  /**
   * @brief Find the maximum path in the graph using Dijkstra's algorithm. As
   * the graph can't be changed after it's created, the maximum path is
   * calculated only once and stored in the maximum_path_ attribute.
   *
   * @return std::shared_ptr<Path> The maximum path in the graph.
   */
  std::shared_ptr<Path> find_maximum_path();

 private:
  std::vector<std::shared_ptr<Node>> nodes_{};
  std::shared_ptr<Path> maximum_path_;

  /**
   * @brief Load nodes from a string.
   *
   * @param nodes The string of nodes.It should follow the format "1\n2
   * 3\n7 8 9", where each value is a node and each line is a level of the
   * pyramid.
   * @return std::vector<std::shared_ptr<Node>> The vector of nodes.
   */
  [[nodiscard]] std::vector<std::shared_ptr<Node>> load_nodes_from_string(
      const std::string& nodes) const;

  /**
   * @brief Load nodes from a file.
   *
   * @param file_path The file with the nodes. It should follow the format "1\n2
   * 3\n7 8 9", where each value is a node and each line is a level of the
   * pyramid.
   * @return std::vector<std::shared_ptr<Node>>  The vector of nodes.
   */
  [[nodiscard]] std::vector<std::shared_ptr<Node>> load_nodes_from_file(
      const std::filesystem::path& file_path) const;

  int find_maximum_path_recursively(
      std::shared_ptr<Node> current_node,
      std::vector<std::shared_ptr<Node>>& path_nodes, size_t& step,
      size_t level);

  void check_child(std::shared_ptr<Node> current_node,
                   std::shared_ptr<Node> child, int& max_value,
                   std::vector<std::shared_ptr<Node>>& path_nodes, size_t& step,
                   size_t& level);
};

}  // namespace company000_exercise_1

#endif  // JOB_INTERVIEWS_COMPANY000_EXERCISE_1_TRIANGLE_DIRECTED_GRAPH_H_
