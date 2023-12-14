using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P6M02ImplementTheVisualStudioCodeDebuggingToolsForCSharp {

    public static class Program {

        public static void Main() {
            // I could not make the debugger work in VS Code with bazel for C#, so I tested it for C++ using lldb :(
            // However, here are some notes from the course

            // The Visual Studio Code user interface can be used to configure, start, and manage debug sessions. The launch.json file contains the launch configurations for your application.
            // The Run menu provides easy access to common run and debug commands grouped into six sections.
            // The RUN AND DEBUG view provides access to runtime tools, including the Run and Debug controls panel. The sections of the RUN AND DEBUG view are VARIABLES, WATCH, CALL STACK, and BREAKPOINTS.
            // The Debug toolbar provides execution controls while your application is running such as pause/continue, step over, step into, step out, restart and stop.
            // The DEBUG CONSOLE is used to display messages from the debugger. The DEBUG CONSOLE can also display console output from your application.

            // Breakpoints
            // Visual Studio Code enables setting breakpoints in the code editor or from the Run menu. Breakpoint code lines are marked with a red dot to the left of the line number.
            // Breakpoints can be removed or disabled using the same options used to set them. Bulk operations that affect all breakpoints are available on the Run menu.
            // Conditional breakpoints can be used to pause execution when a specified condition is met or when a 'hit count' is reached.
            // Logpoints can be used to log information to the terminal without pausing execution or inserting code.
            // Step into (F11) - Executes the next line of code and steps into any method calls on that line.
            // Step over (F10) - Executes the next line of code and steps over any method calls on that line.
            // Step out (Shift+F11) - Steps out of the current method and returns to the calling method.
            // Continue (F5) - Continues execution until the next breakpoint is reached.

            // Launch configurations
            // The launch.json file contains the launch configurations for your application. The launch.json file is located in the .vscode folder in the root of your project.
            // Launch configurations are used to specify attributes such as name, type, request, preLaunchTask, program, and console.
            // Developers can edit a launch configuration to accommodate project requirements.

            // Monitoring variables
            // Monitor variable state using the VARIABLES section of the RUN AND DEBUG view.
            // Track an expression across time or different methods using the WATCH section of the RUN AND DEBUG view.
            // Use the CALL STACK section of the RUN AND DEBUG view to find the source location of an exception or a WATCH expression.
            // Use the VARIABLES section to change a variable's assigned value at runtime.

        }

    }

}