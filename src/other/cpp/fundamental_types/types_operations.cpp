#include <gtest/gtest.h>
#include <cstdint>

TEST(TypesOperationsTest, TimeInMicrosecondsToSecondsAndNanoseconds) {
  // Arrange
  uint64_t time_in_microseconds = 123456789;
  uint32_t time_in_seconds = time_in_microseconds / 1000000;
  uint32_t time_in_nanoseconds =
      (time_in_microseconds % 1000000) * 1000;  // we can't use 1e6 or 1e3
                                                // because they are doubles

  // Assert
  EXPECT_EQ(time_in_seconds, 123);
  EXPECT_EQ(time_in_nanoseconds, 456789000);
}
