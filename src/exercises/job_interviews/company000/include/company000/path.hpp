#ifndef JOB_INTERVIEWS_COMPANY000_EXERCISE_1_PATH_H_
#define JOB_INTERVIEWS_COMPANY000_EXERCISE_1_PATH_H_

#include <glog/logging.h>
#include <memory>
#include <ostream>
#include <vector>
#include "node.hpp"

namespace company000_exercise_1 {

/**
 * @brief Path class. It represents a path as a vector of nodes.
 *
 */
class Path {
 public:
  /**
   * @brief Construct a new Path object. It initializes the value of the path.
   *
   * @param path the list of nodes that form the path in order.
   */
  explicit Path(std::vector<std::shared_ptr<Node>> path);

  /**
   * @brief Overloaded stream insertion operator function to print the path.
   *
   * @param os The output stream.
   * @param path The path to be printed.
   * @return std::ostream& The output stream.
   */
  friend std::ostream& operator<<(std::ostream& os, Path const& path);

  /**
   * @brief Get the total value of the path. It is the sum of the values of the
   * nodes.
   *
   * @return int The total value of the path.
   */
  [[nodiscard]] int get_total_value() const;

  /**
   * @brief Get the list of nodes that form the path in order
   *
   * @return std::vector<std::shared_ptr<Node>>
   */
  [[nodiscard]] std::vector<std::shared_ptr<Node>> get_nodes() const;

  [[nodiscard]] bool contains_node(const std::shared_ptr<Node>& node) const;

 private:
  int total_value_{};
  std::vector<std::shared_ptr<Node>> path_{};
};

}  // namespace company000_exercise_1

#endif  // JOB_INTERVIEWS_COMPANY000_EXERCISE_1_PATH_H_
