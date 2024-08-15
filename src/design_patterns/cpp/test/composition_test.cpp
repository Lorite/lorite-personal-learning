#include "design_patterns/composition.hpp"
#include <gtest/gtest.h>

TEST(CompositionUnitTest, LegsTest) {
  composition::Legs legs;
  testing::internal::CaptureStdout();
  legs.walk();
  std::string output = testing::internal::GetCapturedStdout();
  std::string expected_output = "Walking with my legs\n";
  EXPECT_EQ(output, expected_output);
}

TEST(CompositionUnitTest, WheelsTest) {
  composition::Wheels wheels;
  testing::internal::CaptureStdout();
  wheels.walk();
  std::string output = testing::internal::GetCapturedStdout();
  std::string expected_output = "Rolling with my wheels\n";
  EXPECT_EQ(output, expected_output);
}

TEST(CompositionUnitTest, ArmsTest) {
  composition::Arms arms;
  testing::internal::CaptureStdout();
  arms.grab();
  std::string output = testing::internal::GetCapturedStdout();
  std::string expected_output = "Grabbing things with my arms\n";
  EXPECT_EQ(output, expected_output);
}

TEST(CompositionIntegrationTest, MobileCobotTest) {
  // This would be an integration-like test
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

TEST(CompositionIntegrationTest, HumanoidCobotTest) {
  // This would be an integration-like test
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
