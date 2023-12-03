using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P4M04FormatAlphanumericDataForPresentation {

    public static class Program {

        public static void Main() {
            // From a high-level perspective, software developers are concerned with:
                // - data input, including data typed in by a user from a keyboard, using their mouse, a device, or by another software system via a network request.
                // - data processing, including decision logic, manipulating data, and performing calculations.
                // - data output, including presentation to an end user via a command-line message, a window, a web page, or saving the processed data into a file, and sending it to a network service.

            // Exercise - Investigate string formatting basics
            // Composite Formatting
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
            Console.WriteLine("{0} {0} {0}!", first, second);

            // String interpolation
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");

            // Formatting currency
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // C is the currency format specifier. It will format the value as a currency value depending on the country/region settings of the computer.

            // Formatting numbers
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units"); // N is the number format specifier. It will format the value with thousand separators. It also depends on the country/region settings of the computer.
            Console.WriteLine($"Measurement: {measurement:N4} units"); // N4 will format the value with thousand separators and four decimal places.
            // Formatting percentages
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}"); // P is the percentage format specifier. It will format the value as a percentage. The number after the P indicates the number of decimal places to display.
        
            // Combining formatting approaches
            decimal price2 = 67.55m;
            decimal salePrice = 59.99m;
            string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);
            yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
            Console.WriteLine(yourDiscount);

            // Padding and alignment
            string textToPad = "Pad this";
            Console.WriteLine(textToPad.PadLeft(12)); // textToPad.PadLeft(12) will pad the string with spaces to the left so that the total length of the string is 12 characters. So it will add 4 spaces to the left of the string.
            Console.WriteLine(textToPad.PadRight(12)); // textToPad.PadRight(12) will pad the string with spaces to the right so that the total length of the string is 12 characters. So it will add 4 spaces to the right of the string.
            Console.WriteLine(textToPad.PadLeft(12, '-')); // PadLeft() and PadRight() can also take a second parameter that specifies the character to use for padding. This is an overloaded method. It will add 4 dashes to the left of the string.
            
            // Exercise - Complete a challenge to apply string interpolation to a form letter
            Console.WriteLine("Challenge: Write a form letter");
            string customerName = "Ms. Barros";
            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;
            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";
            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);
            Console.WriteLine(comparisonMessage);
        }

    }

}