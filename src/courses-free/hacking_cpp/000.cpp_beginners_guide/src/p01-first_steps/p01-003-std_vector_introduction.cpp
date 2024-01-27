#include <iostream>
#include <lorite_utils/easy_printing.hpp>
#include <vector>

using EP = lorite_utils::EasyPrinting;

int main() {
  // Initialization
  std::vector<int> v1{};  // Empty vector
  std::cout << "v1: " << EP::vector_to_string(v1) << std::endl;
  std::vector<int> v2{1, 2, 3, 4, 5};  // Vector with 5 elements
  std::cout << "v2: " << EP::vector_to_string(v2) << std::endl;
  std::vector<int> v3(5);  // Vector with 5 elements, all initialized to 0
  std::cout << "v3: " << EP::vector_to_string(v3) << std::endl;
  std::vector<int> v4(5, 1);  // Vector with 5 elements, all initialized to 1
  std::cout << "v4: " << EP::vector_to_string(v4) << std::endl;
  std::vector<int> v5(v2);  // Copy of v2
  std::cout << "v5: " << EP::vector_to_string(v5) << std::endl;
  std::vector<int> v6(v2.begin(), v2.begin() + 3);  // Copy of the first 3
                                                    // elements of v2
  std::cout << "v6: " << EP::vector_to_string(v6) << std::endl;
  std::vector<int> v7(v2.end() - 3, v2.end());  // Copy of the last 3 elements
                                                // of v2
  std::cout << "v7: " << EP::vector_to_string(v7) << std::endl;
  std::vector<int> v8(v2.rbegin(), v2.rend());  // Copy of v2 in reverse order
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;

  // Accessing elements
  std::cout << "v8[0]: " << v8[0] << std::endl;  // Accessing elements. This is
                                                 // faster than using at() but
                                                 // does not check for out of
                                                 // bounds errors
  std::cout << "v8.at(0): " << v8.at(0) << std::endl;      // Accessing elements
  std::cout << "v8.front(): " << v8.front() << std::endl;  // Accessing the
                                                           // first element
  std::cout << "v8.back(): " << v8.back() << std::endl;    // Accessing the last
                                                           // element

  // Modifying elements
  v8[1] = 10;
  v8.at(2) = 20;
  v8.front() = 30;
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;

  // Append elements
  v8.push_back(40);
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;

  // Resizing the vector
  v8.resize(10);
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;
  v8.resize(15, 50);
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;

  // Erasing elements
  v8.erase(v8.begin() + 1);
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;
  v8.erase(v8.begin() + 1, v8.begin() + 3);
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;
  v8.pop_back();
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;
  v8.clear();
  std::cout << "v8: " << EP::vector_to_string(v8) << std::endl;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- std::vector is C++'s default dynamic array type.
- Copies are always deep copies. This means that modifying the copy will not
affect the original vector. It also does deep assignment, so the same applies
when assigning a vector to another. Same goes for comparisons and ownership.
- Warning: copying vectors can be expensive if the vector is large or if the
contained type is expensive to copy.
*/
