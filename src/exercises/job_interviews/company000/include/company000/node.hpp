#ifndef JOB_INTERVIEWS_COMPANY000_EXERCISE_1_NODE_H_
#define JOB_INTERVIEWS_COMPANY000_EXERCISE_1_NODE_H_

#include <glog/logging.h>
#include <memory>
#include <ostream>
#include <vector>

namespace company000_exercise_1 {

/**
 * @brief Node class. It represents a node in a directed graph. It has a value
 * and a vector of children.
 *
 */
class Node {
 public:
  /**
   * @brief Construct a new Node object. It initializes the value of the node.
   *
   * @param value The value of the node. It should be an integer.
   */
  explicit Node(int value);

  /**
   * @brief Overloaded stream insertion operator function to print the node.
   *
   * @param os The output stream.
   * @param node The node to be printed.
   * @return std::ostream& The output stream.
   */
  friend std::ostream& operator<<(std::ostream& os, Node const& node);

  /**
   * @brief Add a child to the node.
   *
   * @param child The child to be added. It should be a shared pointer to a
   * node.
   */
  void add_child(std::shared_ptr<Node> child);

  /**
   * @brief Get the value of the node.
   *
   * @return int The value of the node.
   */
  [[nodiscard]] int get_value() const;

  /**
   * @brief Get the children of the node.
   *
   * @return std::vector<std::shared_ptr<Node>> The children of the node.
   */
  [[nodiscard]] std::vector<std::shared_ptr<Node>> get_children() const;

  /**
   * @brief Check if the node is even.
   *
   * @return bool True if the node is even, false otherwise.
   */
  [[nodiscard]] bool is_even() const;

 private:
  int value_{};
  std::vector<std::shared_ptr<Node>> children_{};
};

}  // namespace company000_exercise_1

#endif  // JOB_INTERVIEWS_COMPANY000_EXERCISE_1_NODE_H_
