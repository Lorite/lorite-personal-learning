package examples.bazel_test_project_java;
// import org.beryx.textio.TextIO;
// import org.beryx.textio.TextIoFactory;


public class HelloJava {
    
    public HelloJava(String greeting) {
        this.greeting = greeting;
    }

    public void greet() {
        System.out.println(this.greeting);
    }

    private String greeting;
}
