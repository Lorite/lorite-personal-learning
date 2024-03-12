#include <benchmark/benchmark.h>
#include <memory>
#include <vector>
#include "solution_cpp.hpp"

static auto nums = std::vector<int>{2, 7, 11, 15};
static auto target = 13;

static void benchmark_two_sum_v1(benchmark::State& st) {
  auto solution_cpp = std::make_shared<two_sum::SolutionCppV1>();
  for (auto _ : st) {
    auto indices = solution_cpp->two_sum(nums, target);
  }
}

static void benchmark_two_sum_v2(benchmark::State& st) {
  auto solution_cpp = std::make_shared<two_sum::SolutionCppV2>();
  for (auto _ : st) {
    auto indices = solution_cpp->two_sum(nums, target);
  }
}

static void benchmark_two_sum_v3(benchmark::State& st) {
  auto solution_cpp = std::make_shared<two_sum::SolutionCppV3>();
  for (auto _ : st) {
    auto indices = solution_cpp->two_sum(nums, target);
  }
}

BENCHMARK(benchmark_two_sum_v1)
    ->Threads(8)
    ->RangeMultiplier(4)
    ->Range(256, 32 * 1024);
BENCHMARK(benchmark_two_sum_v2)
    ->Threads(8)
    ->RangeMultiplier(4)
    ->Range(256, 32 * 1024);
BENCHMARK(benchmark_two_sum_v3)
    ->Threads(8)
    ->RangeMultiplier(4)
    ->Range(256, 32 * 1024);

BENCHMARK_MAIN();
