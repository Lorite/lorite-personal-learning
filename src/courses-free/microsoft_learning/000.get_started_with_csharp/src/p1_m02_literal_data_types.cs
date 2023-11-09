using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P1M02LiteralDataTypes {

    public static class Program {

        public static void Main() {
            // print different data types
            Console.WriteLine('b'); // char
            Console.WriteLine("Hello World!"); // string
            Console.WriteLine(123); // int
            Console.WriteLine(123.4560F); // float
            Console.WriteLine(123.4560); // double
            Console.WriteLine(123.4560M); // decimal
            Console.WriteLine(true); // bool
            Console.WriteLine(false); // bool
            Console.WriteLine(0b0000_0000_0000_0000_0000_0000_0000_0101); // binary
            Console.WriteLine(0x0000_0005); // hexadecimal

            // define variables and initialize them (they can also be initialized later and reassigned)
            char c = 'b';
            string s = "Hello World!";
            int i = 123;
            float f = 123.4560F;
            double d = 123.4560;
            decimal m = 123.4560M;
            bool b = true;
            bool b2 = false;
            int binary = 0b0000_0000_0000_0000_0000_0000_0000_0101;
            int hexadecimal = 0x0000_0005;

            // implicit type local variables. It is used very often.
            // var unitialized; // error
            var c2 = 'b';
            var s2 = "Hello World!";
            var i2 = 123;

            // print a combination of variables and literals
            Console.WriteLine("Mmmm " + c + " " + s + " " + i + " " + f + " " + d + " " + m + " " + b + " " + b2 + " " + binary + " " + hexadecimal);
        }

    }

}
