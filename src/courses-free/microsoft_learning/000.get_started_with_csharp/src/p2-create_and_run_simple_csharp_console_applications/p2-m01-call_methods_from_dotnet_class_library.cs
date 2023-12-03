using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M01CallMethodsFromDotNetClassLibrary {

    public static class Program {

        public static void Main() {
            Console.WriteLine("Hello, World!"); // Console.WriteLine is a method from the .NET Class Library.
            
            Random dice = new Random(); // Random is a class from the .NET Class Library. We create an instance of it called dice.
            Random dice2 = new(); // This is the same as the previous line.
            int roll = dice.Next(1, 7); // Next is an instance method of the Random class. It returns a random integer between 1 and 6. It has two input parameters.
            Console.WriteLine($"You rolled a {roll}. using dice.Next(1, 7) thanks to the Random class from the .NET Class Library.");
            // int result = Random.Next(); // This is an error because Random.Next() is an instance method, not a static method.

            // Overloaded methods are methods with the same name but different input parameters.
            // The compiler knows which method to call based on the input parameters.
            // The following line calls the WriteLine method that takes a string as an input parameter.
            Console.WriteLine("Hello, 42!");
            // The following line calls the WriteLine method that takes an integer as an input parameter.
            Console.WriteLine(42);

            // The Random next method has 3 overloads.
            // The following line calls the overload that takes two integers as input parameters. It returns a random integer (from 1 to 6)
            Console.WriteLine(dice.Next(1, 7));
            // The following line calls the overload that takes one integer as an input parameter. It returns a random integer (from 0 to 6)
            Console.WriteLine(dice.Next(7));
            // The following line calls the overload that takes no input parameters. It returns a random integer (from 0 to 2,147,483,647)
            Console.WriteLine(dice.Next());
        
            // We can learn about .Net classes and methods by reading the documentation or by using a tool called IntelliSense.
            // IntelliSense is a code completion tool that helps you write code faster and with fewer errors. It shows you a list of methods and properties that are available for a class.
            // For documentation, using https://learn.microsoft.com is a good place to start.

            // Code challenge: Implement a method of the Math class that returns the larger of two numbers
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine($"The larger of {firstValue} and {secondValue} is {largerValue}.");

        }

    }
}