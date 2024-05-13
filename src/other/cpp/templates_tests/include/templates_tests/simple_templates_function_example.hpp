#ifndef SIMPLE_TEMPLATES_FUNCTION_EXAMPLE_HPP
#define SIMPLE_TEMPLATES_FUNCTION_EXAMPLE_HPP

namespace templates_tests {

/**
 * @brief Template method. This function adds two values of the same type.
 *
 * @tparam T Type of the values to add.
 * @param a The first value.
 * @param b The second value.
 * @return T The result of adding the two values.
 */
template <typename T>
static T add(T a, T b) {
  return a + b;
}

/**
 * @class MyClass
 * @brief A simple template class that holds a value of type T.
 *
 * This class is a simple example of a template class in C++. It holds a value
 * of type T. The type T is determined at compile time.
 *
 * @tparam T The type of the value this class holds.
 */
template <class T>
class MyClass {
 public:
  explicit MyClass(T value) : value_(value) {}

  T get_value() const { return value_; }

 private:
  T value_{"default_str"};
};

}  // namespace templates_tests

#endif  // SIMPLE_TEMPLATES_FUNCTION_EXAMPLE_HPP
