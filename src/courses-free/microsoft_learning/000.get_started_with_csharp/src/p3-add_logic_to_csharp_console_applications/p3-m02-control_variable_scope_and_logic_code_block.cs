using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M02ControlVariableScopeAndLogicCodeBlock {

    public static class Program {

        public static void Main() {
            // Create a variable inside of a code block
            bool flag = true;
            if (flag) {
                int value = 10;
                Console.WriteLine($"Inside of code block: {value}");
            }
            // Console.WriteLine($"Outside of code block: {value}"); // error CS0103: The name 'value' does not exist in the current context
            int value2;
            // Console.WriteLine($"Outside of code block: {value2}"); // error CS0165: The name 'value2' does not exist in the current context

            // Remove code blocks from if statements
            // These 3 lines are equivalent. Same applies to if-else statements.
            if (flag) {
                Console.WriteLine("Inside of code block");
            }
            if (flag)
                Console.WriteLine("Inside of code block");
            if (flag) Console.WriteLine("Inside of code block");

            // Code challenge: update problematic code in the code editor
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers) {
                total += number;
                if (number == 42)
                    found = true;
            }
            if (found)
                Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");
        }

    }

}