using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M01EvaluateBooleanExpressionsToMakeDecisions {

    public static class Program {

        public static void Main() {
            // Use the equality operator
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);
            string myValue = "a";
            Console.WriteLine(myValue == "a");
            Console.WriteLine("a" == "a ");
            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            // Use the inequality operator
            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);
            myValue = "a";
            Console.WriteLine(myValue != "a");

            // Use the Comparison operators
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            // Use a method that returns a Boolean
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));
            Console.WriteLine(!pangram.Contains("fox"));
            Console.WriteLine(!pangram.Contains("cow"));

            // Inequality operator versus logical negation
            int a = 7;
            int b = 6;
            Console.WriteLine(a != b); // output: True
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2); // output: False

            // Use a conditional operator
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            // Conditional operator challenge
            // In this challenge, you'll implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either heads or tails.
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            // Decision logic challenge
            // In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify the access that will be granted to users based on their role-based permissions and their career level.
            // Code branches will display a different message to the user depending on their permissions and level.
            string permission = "Admin|Manager";
            int adminLevel = 55;
            if (permission.Contains("Admin")) {
                if (adminLevel > 55) {
                    Console.WriteLine("Welcome, Super Admin user.");
                } else {
                    Console.WriteLine("Welcome, Admin user.");
                }
            } else if (permission.Contains("Manager")) {
                if (adminLevel >= 20) {
                    Console.WriteLine("Contact an Admin for access.");
                } else {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            } else {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }

    }

}