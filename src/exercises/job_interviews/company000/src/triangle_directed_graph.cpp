#include "triangle_directed_graph.hpp"
#include <filesystem>
#include <iostream>
#include <memory>

namespace company000_exercise_1 {

TriangleDirectedGraph::TriangleDirectedGraph(const std::string& nodes_string) {
  nodes_ = load_nodes_from_string(nodes_string);
}

TriangleDirectedGraph::TriangleDirectedGraph(
    const std::filesystem::path& file_path) {
  nodes_ = load_nodes_from_file(file_path);
}

std::ostream& operator<<(std::ostream& os,
                         TriangleDirectedGraph const& triangle_directed_graph) {
  size_t level = 0;
  auto cyan_delimiter = "\033[1;36m";
  auto black_delimiter = "\033[0m";
  for (size_t index = 0; const auto& node : triangle_directed_graph.nodes_) {
    if (index == level) {
      if (triangle_directed_graph.maximum_path_ != nullptr &&
          triangle_directed_graph.maximum_path_->contains_node(node)) {
        os << cyan_delimiter;
      }
      os << node->get_value() << black_delimiter << "\n";
      level++;
      index = 0;
    } else {
      if (triangle_directed_graph.maximum_path_ != nullptr &&
          triangle_directed_graph.maximum_path_->contains_node(node)) {
        os << cyan_delimiter;
      }
      os << node->get_value() << black_delimiter << " ";
      index++;
    }
  }
  if (triangle_directed_graph.maximum_path_ != nullptr) {}
  return os;
}

std::vector<std::shared_ptr<Node>>
TriangleDirectedGraph::load_nodes_from_string(
    const std::string& nodes_str) const {
  std::vector<std::shared_ptr<Node>> nodes{};
  std::istringstream iss(nodes_str);
  std::string line;
  int level = 0;
  size_t total_nodes = 0;
  while (std::getline(iss, line)) {  // read each line
    std::istringstream iss_line(line);
    std::string value;
    int position = 0;
    while (iss_line >> value) {  // read each value in the line
      auto node = std::make_shared<Node>(std::stoi(value));
      nodes.push_back(node);
      if (level > 0) {
        if (position != level) {  // not the last node in the level
          nodes[total_nodes - level]->add_child(node);
        }
        if (position != 0) {  // not the first node in the level
          nodes[total_nodes - level - 1]->add_child(node);
        }
      }
      position++;
      total_nodes++;
    }
    if (position != level + 1) {
      throw std::invalid_argument("Invalid number of nodes in level " +
                                  std::to_string(level));
    }
    level++;
  }

  LOG(INFO) << "TriangleDirectedGraph::load_nodes_from_string: Triangle "
               "directed graph loaded from string. Number of nodes: "
            << nodes_.size();

  return nodes;
}

std::vector<std::shared_ptr<Node>> TriangleDirectedGraph::load_nodes_from_file(
    const std::filesystem::path& file_path) const {
  if (!std::filesystem::is_regular_file(file_path)) {
    throw std::invalid_argument("File does not exist");
  }
  std::ifstream ifstream;
  ifstream.open(file_path, std::ios::in);
  std::stringstream buffer;
  buffer << ifstream.rdbuf();
  return load_nodes_from_string(buffer.str());
}

std::shared_ptr<Path> TriangleDirectedGraph::find_maximum_path() {
  std::vector<std::shared_ptr<Node>> nodes{};
  size_t step = 0;
  size_t level = 0;
  find_maximum_path_recursively(nodes_.at(0), nodes, step, level);
  std::reverse(nodes.begin(), nodes.end());  // nodes are reversed in the
                                             // recursive function
  maximum_path_ = std::make_shared<Path>(nodes);
  return maximum_path_;
}

int TriangleDirectedGraph::find_maximum_path_recursively(
    std::shared_ptr<Node> current_node,
    std::vector<std::shared_ptr<Node>>& path_nodes, size_t& step,
    size_t level) {
  LOG(INFO) << "TriangleDirectedGraph::find_maximum_path_recursively:\n - Step "
               "number "
            << step << ":\n - Level: " << level
            << "\n - Current node: " << *current_node
            << "\n - Path nodes: " << path_nodes.size();
  step++;

  // if the node has no children it's a leaf
  if (current_node->get_children().empty()) {
    path_nodes.push_back(current_node);
    return current_node->get_value();
  }

  // find the maximum path recursively for each child
  // we know that there are always two children if it's not a leaf
  int max_value = 0;
  level++;
  check_child(current_node, current_node->get_children().at(0), max_value,
              path_nodes, step, level);
  check_child(current_node, current_node->get_children().at(1), max_value,
              path_nodes, step, level);

  return current_node->get_value() + max_value;  // return the maximum path
}

void TriangleDirectedGraph::check_child(
    std::shared_ptr<Node> current_node, std::shared_ptr<Node> child,
    int& max_value, std::vector<std::shared_ptr<Node>>& path_nodes,
    size_t& step, size_t& level) {
  if (child->is_even() != current_node->is_even()) {
    std::vector<std::shared_ptr<Node>> max_node_local_path_nodes{};
    auto max_child = find_maximum_path_recursively(
        child, max_node_local_path_nodes, step, level);
    if (max_child > max_value) {
      max_value = max_child;
      max_node_local_path_nodes.push_back(current_node);
      path_nodes = max_node_local_path_nodes;
    }
  }
}

}  // namespace company000_exercise_1
