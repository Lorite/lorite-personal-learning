#include "hello-lib.hpp"

#include <iostream>
#include <memory>

namespace hello {

HelloLib::HelloLib(const std::string& greeting)
    : greeting_(std::make_unique<std::string>(greeting)) {
  LOG(INFO) << "HelloLib constructor";
}

void HelloLib::greet(const std::string& thing) {
  if (greeting_ == nullptr) {
    LOG(ERROR) << "greeting_ is nullptr";
    return;
  }

  std::cout << *greeting_ << " " << thing << std::endl;
}

}  // namespace hello
