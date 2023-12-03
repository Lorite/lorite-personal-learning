using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P4M03PerformOperationsOnArraysUsingHelperMethods {

    public static class Program {

        public static void Main() {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("Original array:");
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // Sort the array
            Array.Sort(pallets);
            Console.WriteLine("Sorted array:");
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // Reverse sort the array
            Array.Reverse(pallets);
            Console.WriteLine("Reverse sorted array:");
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // Clear
            Array.Clear(pallets, 0, 2); // Clear first two elements by setting them to null
            Console.WriteLine($"Cleared array: (size: {pallets.Length})");
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // Resize
            Array.Resize(ref pallets, 6); // Resize array to 6 elements. We use the ref keyword to pass the array by reference, otherwise the array would be passed by value and the original array would not be resized.
            Console.WriteLine($"Resized array: (size: {pallets.Length})");
            pallets[4] = "C01";
            pallets[5] = "C02";
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // Use Resize() to shrink an array
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Shrunk array: (size: {pallets.Length})");
            foreach (var pallet in pallets) {
                Console.WriteLine($"-- {pallet}");
            }

            // String to array
            string value = "abc123";
            Console.WriteLine($"The initial string: {value}");
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine($"Reversed string: {result}");

            // Join
            result = string.Join(".", valueArray);
            Console.WriteLine($"Joined string: {result}");

            // Split
            string[] split = result.Split('.');
            Console.WriteLine($"Split string: (size: {split.Length})");
            foreach (var item in split) {
                Console.WriteLine($"-- {item}");
            }

            // Exercise - Complete a challenge to reverse words in a sentence
            string sentence = "The quick brown fox jumped over the lazy dog";
            Console.WriteLine($"The initial sentence: {sentence}");
            // Obtain the following result: "ehT kciuq nworb xof spmuj revo eht yzal god"
            string[] message = sentence.Split(' ');
            string[] newMessage = new string[message.Length];
            for (int i = 0; i < message.Length; i++) {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }
            result = String.Join(" ", newMessage);
            Console.WriteLine($"The reversed sentence: {result}");

            // Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');
            Array.Sort(items);
            foreach (var item in items) {
                if (item.Length == 4) {
                    Console.WriteLine(item);
                } else {
                    Console.WriteLine(item + "\t- Error");
                }
            }
        }

    }

}