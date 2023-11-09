using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P1M02BasicOperationsOnNumbers {

    public static class Program {

        public static void Main() {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            // Mix data types to force implicit type conversions
            Console.WriteLine(firstNumber + 12.5);
            Console.WriteLine("Bob is " + firstNumber + " years old.");

            // Explicit type conversions
            Console.WriteLine("Mark is " + (firstNumber + 3) + " years old."); // The parentheses symbol () becomes another overloaded operator in C#.
            Console.WriteLine(firstNumber + (int)12.5);

            // Basic math operations
            Console.WriteLine("sum = " + (firstNumber + secondNumber));
            Console.WriteLine("difference = " + (firstNumber - secondNumber));
            Console.WriteLine("product = " + (firstNumber * secondNumber));
            Console.WriteLine("quotient = " + (firstNumber / secondNumber)); // the quotient is an int (integer division) and the remainder is discarded (truncated)
            Console.WriteLine("remainder = " + (firstNumber % secondNumber));
            float firstNumberFloat = 12.0F;
            Console.WriteLine("quotient = " + (firstNumberFloat / secondNumber));  // now the quotient is a float too
            Console.WriteLine("quotient = " + ((float)firstNumber / secondNumber)); // now the quotient is a float too by explicit type conversion
            // int decimalQuotient = 7.0m / 5.0m; // does not compile

            // Order of operations
            Console.WriteLine("The order of operations is the same as in math. It follows PEMDAS. Parentheses, Exponents, Multiplication, Division, Addition, Subtraction."); 
            Console.WriteLine("order of operations = " + (firstNumber + 2 * secondNumber));

            // Increment and decrement operators
            firstNumber += 3;
            Console.WriteLine("firstNumber after adding 3 = " + firstNumber);
            firstNumber -= 3;
            Console.WriteLine("firstNumber after subtracting 3 = " + firstNumber);
            firstNumber++;
            Console.WriteLine("firstNumber after incrementing = " + firstNumber);
            firstNumber--;
            Console.WriteLine("firstNumber after decrementing = " + firstNumber);

            // Difference between prefix and postfix operators
            Console.WriteLine("firstNumber after incrementing using postfix = " + firstNumber++); // first the value is used and then incremented
            Console.WriteLine("print firstNumber again = " + firstNumber);
            Console.WriteLine("firstNumber after incrementing using prefix = " + ++firstNumber); // first the value is incremented and then used
            Console.WriteLine("print firstNumber again = " + firstNumber);

        }

    }

}