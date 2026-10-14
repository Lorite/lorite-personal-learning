package examples.bazel_test_project_java;

import static org.junit.jupiter.api.Assertions.assertDoesNotThrow;

import org.junit.jupiter.api.Test;

class TestHelloJava {

  @Test
  void testCanGreet() {
    HelloJava helloJava = new HelloJava("Hello, Java!");
    assertDoesNotThrow(
        () -> {
          helloJava.greet();
        });
  }
}
