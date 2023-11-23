using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M03StoreAndIterateThroughSequencesOfDataUsingArraysAndForeach {

    public static class Program {

        public static void Main() {
            // C# arrays allow you to store sequences of values in a single data structure. In other words, imagine a single variable that can hold many values.
            // Once you have a single variable that stores all the values, you can sort the values, reverse the order of the values, loop through each value and inspect it individually, and so on.

            // Exercise: Your work in the security department is focused on finding a pattern for fraudulent orders. You want your code to review past customer orders and identify markers associated with fraudulent orders.
            // Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed.
            // Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID. How can you create a data structure to hold multiple related values?

            // Declaring arrays and accessing array elements
            string[] fraudulentOrderIDs = new string[3]; // This is an array of strings. It can hold 3 strings. The array is empty. Each element is accessed individually by specifying zero-based index number inside the square brackets.
            fraudulentOrderIDs[0] = "A123"; // This is the first element of the array. It is a string.
            fraudulentOrderIDs[1] = "B456"; // This is the second element of the array. It is a string.
            fraudulentOrderIDs[2] = "C789"; // This is the third element of the array. It is a string.
            // fraudulentOrderIDs[3] = "D000"; // This is a runtime error because the array can only hold 3 strings. This is the fourth element of the array.
            Console.WriteLine($"First fraudulent order ID: {fraudulentOrderIDs[0]}"); // We can access individual elements of the array by specifying the zero-based index number inside the square brackets.
            fraudulentOrderIDs[0] = "F000"; // We can change the value of an element of the array by specifying the zero-based index number inside the square brackets.
            Console.WriteLine($"Reassigned first fraudulent order ID: {fraudulentOrderIDs[0]}");

            string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" }; // We can declare and initialize an array in a single line of code.

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); // We can use the Length property to determine the number of elements in the array.

            // Exercise: Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship.
            // In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total.
            // This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".

            // Iterating through arrays
            // We can use a foreach to iterate through each element of the array.
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            // Exercise: Report the Order IDs that need further investigation
            // Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate.
            // You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            Console.WriteLine("Fraudulent Order IDs:");
            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }


        }

    }
}