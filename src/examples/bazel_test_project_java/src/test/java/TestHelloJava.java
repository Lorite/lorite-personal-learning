package examples.bazel_test_project_java;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.Test;
import examples.bazel_test_project_java.HelloJava;

public class TestHelloJava {

  @Test
  public void testCanGreet() throws Exception {
    HelloJava helloJava = new HelloJava("Hello, Java!");
    assertDoesNotThrow(() -> {helloJava.greet();});
    
  }

}
