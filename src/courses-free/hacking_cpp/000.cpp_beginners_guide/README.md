# Notes

The notes on this file are only for the introduction part. Notes regarding specific concepts can be found as comments in the code under the `src` directory.

## Introduction

This guide is an organized collection of links to topic articles for learning modern, idiomatic C++. It is (roughly) ordered by increasing level of C++ proficiency. Finally, many articles are based on slide decks taken from an undergraduate C++ crash course.

## Required knowledge

You should know how to use a command line and should have a basic understanding of fundamental imperative programming concepts, like:

- variables (int i = 0, var x = 0, … )
- conditional branching (if, then, else, … )
- loops (for, while, repeat, … )
- functions / subroutines (int main(), fn main, … )

## What is C++?

C++ is a general-purpose programming language created by Bjarne Stroustrup as an extension of the C programming language, or "C with Classes". The language has expanded significantly over time, and modern C++ now has object-oriented, generic, and functional features in addition to facilities for low-level memory manipulation. It is almost always implemented as a compiled language, and many vendors provide C++ compilers, including the Free Software Foundation, LLVM, Microsoft, Intel, Oracle, and IBM, so it is available on many platforms. Some features:

- multi-paradigm: value-oriented, procedural, generic, functional, object-oriented.
- value semantics by default.
- custom types can behave exactly like built-in types.
- deterministic object lifetime.
- precise memory control down to individual bits.

C++ is standardized by the International Organization for Standardization (ISO). The latest version of the standard is C++23. This is a summary of the changes:
| Standard | Year | info |
| ------------- | ------------- | ------------- |
| C++98 | 1998 | the original standard |
| C++11 | 2011 | almost a new language |
| C++14 | 2014 | some improvements |
| C++17 | 2017 | new features & library extensions |
| C++20 | 2020 | game-changing new features & libraries |
| C++23 | 2023 | new features & library extensions |

## C++ when to use and when not to use

### When to use

- if memory consumption is critical.
- if runtime is critical.
- if energy consumption is critical.
- OS level programming.
- embedded systems.
- large-scale, massively parallel systems.
- source-code portability across architectures.

### When not to use

- "scripting" & rapid prototyping.
- GUIs with trivial internal logic.

# How to run the code

To build all the files in the course, run the following in the root directory of the course:

```bash
bazel build //...
```

To run a specific file, run the following in the root directory of the course:

```bash
bazel run //:target
```

where `target` is the name of the file without the extension. For example, p1_m02_literal_data_types_bin.
You can find all available targets in the BUILD file in the root directory of the course. Also using tab completion in the command line should work. And also using bazel query.

```bash
bazel query //:*
```

# Outcomes of the course

This is a really nice guide to learn C++ basics. The infographics are really nice and the explanations are clear and concise. I really like the way the author explains the concepts. I think this is a really good resource to learn C++.

## Certificate

There is no certificate for this course.

# Sources:

- [hacking C++ | C++ Beginner's Guide](https://hackingcpp.com/cpp/beginners_guide.html)
- [Principles and Practice Using C++](https://www.amazon.com/Programming-Principles-Practice-Using-2nd/dp/0321992784/ref=sr_1_1?crid=3KQ1CW1RG41WP&keywords=programming+principles+and+practice+using+c%2B%2B&qid=1569486163&s=gateway&sprefix=principles+and+practice+of+using+c%2B%2B%2Caps%2C210&sr=8-1)
- [C++ Primer](https://www.amazon.com/Primer-5th-Stanley-B-Lippman/dp/0321714113)
- [C++ Super-FAQ](https://isocpp.org/wiki/faq)
- [More Books…](https://hackingcpp.com/cpp/books.html)
- [More Online Resources…](https://hackingcpp.com/dev/web_learning.html)
