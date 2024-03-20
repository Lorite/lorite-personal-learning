#include "node.hpp"

#include <iostream>

namespace company000_exercise_1 {

Node::Node(int value) : value_(value) {}

std::ostream& operator<<(std::ostream& os, Node const& node) {
  os << "Node:\n\tPointer: " << &node << "\n\tValue: " << node.value_
     << "\n\tChildren pointers: ";
  for (const auto& child : node.children_) {
    os << &child << " ";
  }
  os << "\n";
  return os;
}

void Node::add_child(std::shared_ptr<Node> child) {
  children_.push_back(child);
}

[[nodiscard]] int Node::get_value() const {
  return value_;
}

[[nodiscard]] std::vector<std::shared_ptr<Node>> Node::get_children() const {
  return children_;
}

[[nodiscard]] bool Node::is_even() const {
  return value_ % 2 == 0;
}

}  // namespace company000_exercise_1
