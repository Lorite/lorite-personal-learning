using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P5M01WriteYourFirstMethod {

    public static class Program {
        static void SayHello() { // The method signature consists of the return type, the name of the method, and the parameter list.
                                    // There are also keywords that can be used to modify the signature.
                                    // In this case, the method is static, which means it can be called without creating an instance of the class.
            Console.WriteLine("Hello World!");
        }

        // Exercise - Create a method to display random numbers
        static void DisplayRandomNumbers() {
            Random random = new Random();
            for (int i = 0; i < 5; i++) {
                Console.Write($"{random.Next(1, 100)} ");
            }
            Console.WriteLine();
        }

        // Main method
        public static void Main() { // The main method is the entry point for a C# console application. We have been using it since the beginning of this course.
            // Methods, also called functions, are a key part of keeping code structured, efficient, and readable.
            // A method is a modular unit of code, and a fundamental programming concept.
            // A method is often designed to perform a specific task and contains code to execute that task.
            // The name of a method should clearly reflect its task, which improves code readability.
            // Learning how to use methods will help you build feature-rich applications more quickly.

            SayHello(); // Call the method

            // Exercise - Create a method to display random numbers
            DisplayRandomNumbers();

            // --------------------------------------------------

            // Exercise - Create reusable methods.
            // Reorganize the code to use methods. (the original code is not included here)
            int[] times = {800, 1200, 1600, 2000};
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                Console.WriteLine("Invalid GMT");
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            } else {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes();
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

            void DisplayTimes() { // We can also define methods inside other methods. These are called local methods.
                /* Format and display medicine times */
                foreach (int val in times) {
                    string time = val.ToString();
                    int len = time.Length;

                    if (len >= 3)
                        time = time.Insert(len - 2, ":");
                    else if (len == 2)
                        time = time.Insert(0, "0:");
                    else
                        time = time.Insert(0, "0:0");

                    Console.Write($"{time} ");
                }
                Console.WriteLine();
            }

            void AdjustTimes() { // Another local method
                /* Adjust the times by adding the difference, keeping the value within 24 hours */
                for (int i = 0; i < times.Length; i++) 
                    times[i] = ((times[i] + diff)) % 2400;
            }

            // --------------------------------------------------

            // Exercise - Build code with methods
            // Suppose you're a candidate in a coding interview. The interviewer wants you to write a program that checks whether an IPv4 address is valid or invalid. You're given the following rules:
            //     A valid IPv4 address consists of four numbers separated by dots
            //     Each number must not contain leading zeroes
            //     Each number must range from 0 to 255
            // 1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.
            // The IPv4 address is provided as a string. You can assume that it only consists of digits and dots (there are no letters in the string provided).
            string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input) {
                address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                ValidateLength(); 
                ValidateZeroes(); 
                ValidateRange();

                if (validLength && validZeroes && validRange)  {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                } else {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength() {
                validLength = address.Length == 4;
            }

            void ValidateZeroes() {
                foreach (string number in address) {
                    if (number.Length > 1 && number.StartsWith("0")) {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            }

            void ValidateRange() {
                foreach (string number in address) {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255) {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }

            // --------------------------------------------------

            // Exercise - Complete the challenge to create a reusable method
            // You're helping to develop a massive multiplayer role-playing game. Each player has a luck stat that can affect their odds of finding rare treasure.
            // Each day, a player can speak to an in-game fortune teller that reveals whether their luck stat is high, low, or neutral.
            // The game currently has code to generate a player's fortune, but it isn't reusable.
            // Your task is to create a tellFortune method that can be called at any time, and replace the existing logic with a call to your method.

            Random random = new Random();

            string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
            string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
            string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
            string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

            Console.WriteLine("Fortune Teller");
            int luck = random.Next(100);
            Console.WriteLine($"Your luck today is {luck}.");
            TellFortune();
            luck = random.Next(100);
            Console.WriteLine($"Your luck tomorrow is {luck}.");
            TellFortune();

            void TellFortune() {
                Console.WriteLine("A fortune teller whispers the following words:");
                string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
                for (int i = 0; i < 4; i++)  {
                    Console.Write($"{text[i]} {fortune[i]} ");
                }
                Console.WriteLine();
            }

        }

    }

}