package examples.bazel_test_project_java;
import examples.bazel_test_project_java.HelloJava;

public class Main {

    public static void main(String[] args) {
        HelloJava helloJava = new HelloJava("Hello, Java!");
        helloJava.greet();
    }

}
