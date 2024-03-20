#include <cstdio>
#include <filesystem>
#include <memory>
#include <stdexcept>
#include <vector>
#include "path.hpp"
#include "triangle_directed_graph.hpp"

void print_help(const char* program_name) {
  std::cout << "Usage: " << program_name << " <file_path>" << std::endl;
}

// I could have used a standard library for parsing command line arguments, but
// I preferred using the standard library.
int main(int argc, const char** argv) {
  // initialize the logging
  google::InitGoogleLogging(argv[0]);

  // create a menu to display help and to pass an argument to specify the file
  // to load the nodes from
  if (argc == 2) {
    // print the help if the user asks for it
    if (std::string(argv[1]) == "-h" || std::string(argv[1]) == "--help") {
      print_help(argv[0]);
      return 0;
    }

    // create a TriangleDirectedGraph object from the file
    std::shared_ptr<company000_exercise_1::TriangleDirectedGraph> graph;
    try {
      {
        graph = std::make_shared<company000_exercise_1::TriangleDirectedGraph>(
            std::filesystem::path(argv[1]));
      };
    } catch (std::invalid_argument& e) {
      std::cerr << e.what() << std::endl;
      return 1;
    }

    // print the graph
    std::cout << "- Input graph:\n" << *graph << std::endl;

    // find the maximum path
    auto path = graph->find_maximum_path();

    // print the maximum path
    std::cout << "- Maximum path:\n" << *path << std::endl;

    // print the path on the graph
    std::cout << "- Graph with maximum path:\n" << *graph << std::endl;

  } else {
    // print the help
    print_help(argv[0]);
  }

  return 0;
}
