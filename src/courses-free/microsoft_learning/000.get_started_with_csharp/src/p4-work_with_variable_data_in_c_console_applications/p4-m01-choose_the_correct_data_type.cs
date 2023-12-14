using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P4M01ChooseTheCorrectDataType {

    public static class Program {

        public static void Main() {
            // What is data?A
            // Data is a value that is stored in memory as a series of bits (1 or 0).
            // Text is stored as a series of bits that represent characters using a character encoding scheme, such as ASCII or Unicode.
            // A data type is a way a programming language defines how much memory to save for a value.
            // There are many data types in the C# language to be used for many different applications and sizes of data.
            // Value vs. reference types
            // Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else.
            // In comparison, variables of value types directly contain their data.
            // As you learn more about C#, new details emerge related to the fundamental difference between value and reference types.

            // Exercise - Discover integral types
            //  An integral type is a simple value type that represents whole numbers with no fraction (such as -1, 0, 1, 2, 3). The most popular in this category is the int data type.
            // Use MinValue and MaxValue to discover the range of the int data type.
            Console.WriteLine("Signed integral types:");
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            // Unsigned integral types
            // An unsigned integral type is a simple value type that represents whole numbers with no fraction (such as 0, 1, 2, 3). The most popular in this category is the uint data type.
            // Use MinValue and MaxValue to discover the range of the uint data type.
            Console.WriteLine("Unsigned integral types:");
            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            // Exercise - Discover floating-point types
            // A floating-point type is a simple value type that represents numbers with a fractional part (such as -1.5, 0.0, 1.5, 2.5). The most popular in this category is the double data type.
            // Use MinValue and MaxValue to discover the range of the double data type.
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

            // Exercise - Discover reference types
            // Reference types include arrays, classes, and strings. Reference types are treated differently from value types regarding the way values are stored when the application is executing.
            int[] data = new int[3];
            // A reference type is created if the new operator is used to create a variable of that type.

            // What's different about the C# string data type?
            // The string data type is also a reference type. You might be wondering why a new operator wasn't used when declaring a string. This is purely a convenience afforded by the designers of C#.
            // Because the string data type is used so frequently, you can use this format:
            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);

            // How to choose the right data type?
            // Choose the data type that meets the boundary value range requirements of your application
            // Start with choosing the data type to fit the data (not to optimize performance)
            // Choose data types based on the input and output data types of library functions used
            // Choose data types based on impact to other systems
            // When in doubt, stick with the basics (int, decimal, string, bool)
            // Choose specialty complex types for special situations (byte, double, System.DateTime, System.TimeSpan, ...)

        }

    }

}