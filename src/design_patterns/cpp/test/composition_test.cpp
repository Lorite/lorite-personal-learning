#include "design_patterns/composition.hpp"
#include <gtest/gtest.h>

TEST(CompositionTest, MobileCobotTest) {
  composition::CompositionRobot mobile_cobot(
      std::make_unique<composition::Wheels>(),
      std::make_unique<composition::Arms>());
  testing::internal::CaptureStdout();
  mobile_cobot.walk();
  mobile_cobot.grab();
  std::string output = testing::internal::GetCapturedStdout();
  std::string expected_output =
      "Rolling with my wheels\nGrabbing things with my arms\n";
  EXPECT_EQ(output, expected_output);
}

TEST(CompositionTest, HumanoidCobotTest) {
  composition::CompositionRobot humanoid_cobot(
      std::make_unique<composition::Legs>(),
      std::make_unique<composition::Arms>());
  testing::internal::CaptureStdout();
  humanoid_cobot.walk();
  humanoid_cobot.grab();
  std::string output = testing::internal::GetCapturedStdout();
  std::string expected_output =
      "Walking with my legs\nGrabbing things with my arms\n";
  EXPECT_EQ(output, expected_output);
}
