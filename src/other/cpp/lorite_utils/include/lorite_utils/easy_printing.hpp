#ifndef EASY_PRINTING_HPP
#define EASY_PRINTING_HPP

#include <string>
#include <vector>

namespace lorite_utils {
class EasyPrinting {
 public:
  static std::string vector_to_string(std::vector<int> v) {
    std::string s = "[";
    for (size_t i = 0; i < v.size(); i++) {
      s += std::to_string(v[i]);
      if (i < v.size() - 1) {
        s += ", ";
      }
    }
    s += "]";
    return s;
  }
};

}  // namespace lorite_utils

#endif  // EASY_PRINTING_HPP
