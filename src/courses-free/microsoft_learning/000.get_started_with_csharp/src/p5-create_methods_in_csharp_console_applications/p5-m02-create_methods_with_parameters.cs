using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P5M02CreateMethodsWithParameters {

    public static class Program {

        public static void Main() {
            // Methods have the ability to perform operations on input. Passing parameters to your methods allows you to perform the method's task with different input values.
            // Using method parameters lets you extend your code while keeping your program organized and readable.
            // If you consider a method to be a black box that accepts input and performs a single task, you can quickly divide a large problem into workable pieces.
            // Method input parameters are passed by value by default. This means that the method receives a copy of the value, and any changes to the parameter value are not reflected outside of the method.

            // Exercise - Use parameters in methods
            CountTo(5);
            void CountTo(int max) {
                for (int i = 0; i < max; i++) {
                    Console.Write($"${i}, ");
                }
                Console.WriteLine();
            }

            // Method scope
            // It is important to understand that variables declared inside a method are only accessible within that method. This is known as the scope of the variable.

            // Methods that call other methods
            double pi = 3.14159;
            PrintCircleInfo(5);
            PrintCircleInfo(15);

            void PrintCircleArea(int radius) {
                double area = pi * (radius * radius);
                Console.WriteLine($"Area = {area}");
            }

            void PrintCircleCircumference(int radius) {
                double circumference = 2 * pi * radius;
                Console.WriteLine($"Circumference = {circumference}");
            }

            void PrintCircleInfo(int radius) {
                Console.WriteLine($"Circle with radius {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumference(radius);
            }

            // Use value and reference type parameters
            // In C#, variables can be categorized into two main types, value types and reference types. These types describe how variables store their values.
            // Value types such as int, bool, float, double, and char directly contain values. Reference types such as string, array, and objects (such as instances of Random) don't store their values directly.
            // Instead, reference types store an address where their value is being stored.

            // Test pass by Value
            int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a, b, c);
            Console.WriteLine($"global statement: {a} x {b} = {c}");

            void Multiply(int a, int b, int c) {
                c = a * b;
                Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
            }

            // Test pass by reference
            int[] array = {1, 2, 3, 4, 5};

            PrintArray(array);
            Clear(array);
            PrintArray(array);

            void PrintArray(int[] array) {
                foreach (int a in array) {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

            void Clear(int[] array) {
                for (int i = 0; i < array.Length; i++) {
                    array[i] = 0;
                }
            }

            // Test with strings
            string status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth(status, false);
            Console.WriteLine($"End: {status}");

            void SetHealth(string status, bool isHealthy) {
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            }

            // Fix the test with strings by using a global variable. The issue is that Strings can't be altered once assigned, they can only be overwritten with a new value.
            status = "Healthy";

            Console.WriteLine($"Start: {status}");
            SetHealth2(false);
            Console.WriteLine($"End: {status}");

            void SetHealth2(bool isHealthy) { // We rename it to SetHealth2 because C# does not overloading local methods
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            }

            // Methods with optional parameters
            string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
            string[] rsvps = new string[10];
            int count = 0;

            RSVP("Rebecca"); // Call a method with default parameters
            RSVP("Nadia", 2, "Nuts");
            RSVP("Linh", 2, "none", false);
            RSVP("Tony", 1, "Jackfruit", true);
            RSVP("Noor", 4, "none", false);
            RSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVPs();

            void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) { // There are 3 optional parameters: partySize, allergies, inviteOnly
                if (inviteOnly) {
                    bool found = false;
                    foreach (string guest in guestList) {
                        if (guest.Equals(name)) {
                            found = true;
                            break;
                        }
                    }
                    if (!found) {
                        Console.WriteLine($"Sorry, {name} is not on the guest list");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs() {
                Console.WriteLine("Total RSVPs:");
                for (int i = 0; i < count; i++) {
                    Console.WriteLine(rsvps[i]);
                }
            }

            // Call a method with named arguments
            RSVP(name: "Linhhhh", partySize: 2, allergies: "none", inviteOnly: false);
            RSVP("Tonyyyyy", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
            ShowRSVPs();

            // ------------------------------

            // Exercise - Complete the challenge to display email addresses
            // Your challenge is to create a method that displays the correct email address for both internal and external employees.
            // You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.
            // The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".
            string[,] corporate = {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

            string[,] external = {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++) {
                DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
            }

            for (int i = 0; i < external.GetLength(0); i++) {
                DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
            }

            void DisplayEmail(string first, string last, string domain = "contoso.com") {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }

        }

    }

}