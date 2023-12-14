using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P6M01ReviewThePrinciplesOfCodeDebuggingAndExceptionHandling {

    public static class Program {

        public static void Main() {
            // When you set out to develop an application, writing your code is just the first step.
            // The process for verifying that your code works as expected begins shortly after the first lines of code are written.
            // In software development, code verification includes testing, debugging, and exception handling.

            // Testing, debugging, and exception handling
            // Testing is the process of verifying that your code works as expected. The software development process can involve a lot of testing.
            // In fact, software testing has its own specialized discipline, and software testers play an important role in the development of large applications.
            // There are even approaches to the software development process that are based on testing, such as test-driven development.
            // Software testing categories can be organized under the types of testing, the approaches to testing, or a combination of both.
            // One way to categorize the types of testing is to split testing into Functional and Nonfunctional testing.
            // The functional and nonfunctional categories each include subcategories of testing. For example, functional and nonfunctional testing could be divided into the following subcategories:
                // Functional testing - Unit testing - Integration testing - System testing - Acceptance testing
                // Nonfunctional testing - Security testing - Performance testing - Usability testing - Compatibility testing
            // Although most developers probably don't consider themselves to be testers, some level of testing is expected before a developer hands off their work. When developers are assigned a formal role in the testing process, it's often at the level of unit testing.

            // Debugging is the process of identifying and fixing errors in your code.
            // Code debugging is a process that developers use to isolate an issue and identify one or more ways to fix it. The issue could be related to either code logic or an exception.
            // Either way, you work on debugging your code when it isn't working the way you want it to. Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate.
            // Therefore, fixing syntax issues such as a missing ";" at the end of a code statement, isn't normally considered debugging. Code debugging is definitely a developer responsibility.
            // Don't let yourself throw time against the following approaches:
                // Reading through your code (just one more time) hoping that this time the issue jumps out at you.
                // Breadcrumbing a few Console.WriteLine("here") messages in your code to the track progress through your app.
                // Rerunning your app with different data. Hoping that if you see what works, you'll understand what doesn't work.
            // Use a debugger tool instead!! A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach.
            // Debuggers help you isolate the cause of a bug and help you resolve it. A debugger connects to your code using one of two approaches:
                // By hosting your program in its own execution process.
                // By running as a separate process that's attached to your running program.

            // Exception handling is the process of responding to errors that occur during program execution.
            // Errors that occur during the application runtime are referred to as exceptions. If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.
            // Handling exceptions is definitely a responsibility of the developer. C# provides a way for you to "try" the code that you know might generate an exception, and a way for you to "catch" any exceptions that do occur.
            // Exceptions are used in C# to propagate errors at runtime, and are represented by classes derived from the Exception class.
            // Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
            // When an exception is caught, code can access its contents and take corrective action to mitigate the error.
            // The .NET runtime generates exceptions when it detects an error and the exception contains information about the type of error that occurred.

            

        }

    }

}