#include <gtest/gtest.h>

TEST(STDFindTest, TestFindIf) {
    // Arrange
    std::vector<std::string> args = {"--flag1=flag1_value --flag2=flag2_value", "--flag3=flag3_value"};

    // Act
    bool flag2_found = false;
    for (auto arg : args) {
        if (arg.find("--flag2=flag2_value") != std::string::npos) {
            flag2_found = true;
        }
    }
    bool flag4_found = false;
    for (auto arg : args) {
        if (arg.find("--flag4=flag4_value") != std::string::npos) {
            flag4_found = true;
        }
    }

    // Assert
    EXPECT_TRUE(flag2_found);
    EXPECT_FALSE(flag4_found);

    // Act 2 - Using std::find
    auto contains_string_flag2 = [](std::string str) { return str.find("--flag2=flag2_value") != std::string::npos; };
    flag2_found = std::find_if(args.begin(), args.end(), contains_string_flag2) != args.end();
    auto contains_string_flag4 = [](std::string str) { return str.find("--flag4=flag4_value") != std::string::npos; };
    flag4_found = std::find_if(args.begin(), args.end(), contains_string_flag4) != args.end();

    // Assert 2
    EXPECT_TRUE(flag2_found);
    EXPECT_FALSE(flag4_found);
}
