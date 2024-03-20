#include "path.hpp"
#include <cstddef>
#include <sstream>

namespace company000_exercise_1 {

Path::Path(std::vector<std::shared_ptr<Node>> path) : path_(path) {
  for (const auto& node : path_) {
    total_value_ += node->get_value();
  }
}

std::ostream& operator<<(std::ostream& os, Path const& path) {
  os << "Path:\n\tTotal value: " << path.total_value_ << "\n\tNodes: ";

  if (path.path_.empty()) {
    os << "Empty path\n";
    return os;
  }

  auto actual_delim = " -> ";
  auto delim = "";
  for (const auto& node : path.path_) {
    os << delim << node->get_value();
    delim = actual_delim;
  }
  os << "\n";
  return os;
}

[[nodiscard]] int Path::get_total_value() const {
  return total_value_;
}

[[nodiscard]] std::vector<std::shared_ptr<Node>> Path::get_nodes() const {
  return path_;
}

[[nodiscard]] bool Path::contains_node(
    const std::shared_ptr<Node>& node) const {
  return std::find(path_.begin(), path_.end(), node) != path_.end();
}

}  // namespace company000_exercise_1
