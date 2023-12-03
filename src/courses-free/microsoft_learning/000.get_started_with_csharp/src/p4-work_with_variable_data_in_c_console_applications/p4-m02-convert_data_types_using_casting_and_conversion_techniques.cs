using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P4M02ConvertDataTypesUsingCastingAndConversionTechniques {

    public static class Program {

        public static void Main() {
            // There are multiple techniques to perform a data type conversion. The technique you choose depends on your answer to two important questions:
                // Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
                // Is it possible, depending on the value, that attempting to change the value's data type would result in a loss of information?

            // Try to convert a string to an integer
            int first = 2;
            string second = "4";
            // int result = first + second; // error CS0029: Cannot implicitly convert type 'string' to 'int'
            string result = first + second; // Try something else (it's still not going to work as expected)
            Console.WriteLine(result); // output: 24
            // This happens because the + operator is overloaded to perform string concatenation when one of the operands is a string.

            // Widening conversions
            // A widening conversion is a conversion from a smaller data type to a larger data type.
            // Widening conversions are safe because they can't result in a loss of information.
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");
            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            // Narrowing conversions and casting
            // A narrowing conversion is a conversion from a larger data type to a smaller data type.
            // Narrowing conversions are not safe because they can result in a loss of information.
            myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");
            myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            // Use ToString() to convert a number to a string
            int firstInt = 5;
            int secondInt = 7;
            string message1 = firstInt.ToString() + secondInt.ToString();
            Console.WriteLine(message1);

            // Convert a string to an int using the Parse() helper method
            string firstStr = "5";
            string secondStr = "7";
            int sum = int.Parse(firstStr) + int.Parse(secondStr);
            Console.WriteLine(sum);

            // Convert a string to a int using the Convert class
            int resultInt = Convert.ToInt32(firstStr) * Convert.ToInt32(secondStr);
            Console.WriteLine(resultInt);

            // Compare casting and converting a decimal into an int
            int value1 = (int)1.5m; // casting truncates
            Console.WriteLine(value1);
            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);

            // Exercise - Examine the TryParse() method
            // The TryParse() method is a helper method that attempts to convert a string to a numeric data type. It returns a Boolean value that indicates whether the conversion was successful.
            string name = "Bob";
            // Console.WriteLine(int.Parse(name)); // error CS0029: Cannot implicitly convert type 'string' to 'int'
            Console.WriteLine(int.TryParse(name, out int result3)); // output: False
            string numberStr = "123";
            Console.WriteLine(int.TryParse(numberStr, out int result4)); // output: True
            Console.WriteLine(result4); // output: 123

            // Exercise - Complete a challenge to combine string array values as strings and as integers
            // Rules:
                // Rule 1: If the value is alphabetical, concatenate it to form a message.
                // Rule 2: If the value is numeric, add it to the total.
                // Rule 3: The result should match the following output: "Message: ABCDEF Total: 68.3"
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            decimal total = 0m;
            string message = "";

            foreach (var value in values) {
                decimal number; // stores the TryParse "out" value
                if (decimal.TryParse(value, out number)) {
                    total += number;
                } else {
                    message += value;
                }
            }
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");

            // Exercise - Complete a challenge to output math operations as specific number types
            // Solve for result1: Divide value1 by value2, display the result as an int (round to the nearest whole number)
            // Solve for result2: Divide value2 by value3, display the result as a decimal
            // Solve for result3: Divide value3 by value1, display the result as a float
            int valueInt = 12;
            decimal valueDecimal = 6.2m;
            float valueFloat = 4.3f;
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {Convert.ToInt32((decimal) valueInt / valueDecimal)}");
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {valueDecimal / (decimal) valueFloat}");
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {valueFloat / valueInt}"); // casting  int to float is not necessary but it would be a widening conversion because float is larger than int

        }

    }

}