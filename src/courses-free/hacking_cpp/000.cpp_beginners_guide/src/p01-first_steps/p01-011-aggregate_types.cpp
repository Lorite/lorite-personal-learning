#include <iostream>
#include <lorite_utils/easy_printing.hpp>
#include <vector>

using EP = lorite_utils::EasyPrinting;

struct Point {  // Simple aggregate type
  int x;
  int y;
};

struct PointCloud {  // Simple aggregate type
  std::vector<Point> points;
  std::string name;
};

int main() {
  // Type categories:
  // Fundamental type (void, bool, char, int, double, …)
  bool b = true;
  std::cout << "bool: " << b
            << ", as well as void, char, int, double, … are fundamental types."
            << std::endl;
  // Simple aggregate type (array, struct, union)
  Point p = {1, 2};  // aggregate initialization (C++98)
  Point p2{1, 2};    // uniform initialization is also ok
  (void)p2;          // to avoid warning: unused variable 'p2'
  std::cout << "Point: x:" << p.x << ", y:" << p.y;
  p.x = 3;
  std::cout << " -> x:" << p.x << ", y:" << p.y << std::endl;
  PointCloud cloud1{{{1, 2}, {3, 4}}, "mycloud1"};  // compound aggregate
                                                    // initialization
  std::cout << "PointCloud 1: point1: x" << cloud1.points.at(0).x << std::endl;
  PointCloud cloud2 = cloud1;  // copy construction (copies are deep)
  PointCloud cloud3;           // default initialization
  cloud3 = cloud1;             // copy assignment (copies are deep)
  std::cout << "PointCloud 3: name: " << cloud3.name << std::endl;

  std::vector<PointCloud> clouds{cloud1, cloud2, cloud3};  // vector of
                                                           // PointClouds
  // the clouds can also be initialized with the vector constructor
  return 0;
}

/* Notes:
- Check the previous source files for notes on things not mentioned here.
- Type Categories (simplified):
  - Fundamental types: void, bool, char, int, double, …
  - Simple aggregate types: their main purpose is to group data
    - aggregate: may contain one/many fundamental or other aggregate-compatible
types
    - no control over interplay of constituent types
    - "trivial" if only (compiler generated) default construction / destruction
/ copy / assignment
    - "standard memory layout" (all members laid out contiguous in declaration
order), if all members have same access control (e.g. all public)
  - More Complex Custom Types: their main purpose is to enable correctness /
safety guarantees
    - custom invariants and control over interplay of members
    - restricted member access
    - member functions
    - user-defined construction / member initialization
    - user-defined destruction / copy / assignment
    - may be polymorphic (contain virtual member functions)
- Advantages of using custom types / data aggregation:
  - Interfaces become easier to use correctly.
  - It enables returning multiple values from a function.
  - It allows interfaces to remain the same while the implementation changes.
  - It allows for better code organization and readability.
- Value vs. Reference Semantics:
  - Value semantics: = variables refer to objects themselves
    - deep copy: new object is created and all members are copied
    - deep assignment: all members values of the target equal the source
    - deep ownership: member variables refer to objects with same lifetime as
containing object
    - value-based comparison: equality is based on member values
    - Value semantics is the default behavior for fundamental types (int,
double, etc.) in almost all programming languages and also the default for
aggregates/user-defined types in C++.
  - Reference semantics: = variables refer to objects indirectly
    - shallow copy: new object is created, but members are not copied
    - shallow assignment: only the reference to the object is copied
    - shared ownership: member variables refer to objects with different
    - Most other mainstream languages (Java, Python, C#, Swift, …) use
(baked-in) reference semantics for user-defined types.
  - The situation in C++ is consistent and offers full control:
    - Value semantics is the default behavior for all types except C-style
arrays.
    - Optional reference semantics possible for all types via pointers and
references.
- Warning: can't use empty parentheses for object construction due to an
ambiguity in C++'s grammar.
*/
