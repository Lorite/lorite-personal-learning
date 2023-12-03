using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M04IterateThroughACodeBlockUsingForStatement {

    public static class Program {

        public static void Main() {
            // for statement
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done!");
            for (int i = 10; i >= 0; i--){
                Console.WriteLine(i);
            }
            Console.WriteLine("Done!");
            for (int i = 0; i < 10; i += 3) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done!");
            // use break inside of a for loop
            for (int i = 0; i < 10; i++) {
                if (i == 5) {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Done!");
            // Loop through each element of an array
            string[] names = { "Bob", "Conrad", "Grant" };
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }
            // Examine the limitation of the foreach statement
            foreach (var name in names) {
                // if (name == "Bob") name = "Bobby"; // error: Cannot assign to 'name' because it is a 'foreach iteration variable'
                continue;
            }
            // Overcoming the limitation of the foreach statement using the for statement
            for (int i = 0; i < names.Length; i++) {
                if (names[i] == "Bob") names[i] = "Bobby";
            }

            // FizzBuzz challenge
            // Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }

    }

}