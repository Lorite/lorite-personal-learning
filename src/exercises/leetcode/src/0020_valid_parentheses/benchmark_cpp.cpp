#include <benchmark/benchmark.h>

static void bm_string_creation(benchmark::State& state) {
  for (auto _ : state)
    std::string empty_string;
}
// Register the function as a benchmark
BENCHMARK(bm_string_creation);

// Define another benchmark
static void bm_string_copy(benchmark::State& state) {
  std::string x = "hello";
  for (auto _ : state)
    std::string copy(x);
}
BENCHMARK(bm_string_copy);

BENCHMARK_MAIN();
