using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P1M03BasicStringFormatting {

    public static class Program {

        public static void Main() {
            // Format literal strings in C#
            // Character escape sequences
            Console.WriteLine("Hello\nWorld!"); // new line
            Console.WriteLine("Hello\tWorld!"); // tab
            Console.WriteLine("Hello\bWorld!"); // backspace
            Console.WriteLine("Hello\rWorld!"); // carriage return
            Console.WriteLine("Hello\fWorld!"); // form feed
            Console.WriteLine("Hello \'World\'!"); // single quote
            Console.WriteLine("Hello \"World\"!"); // double quote
            Console.WriteLine("Hello \\World\\!"); // backslash
            Console.WriteLine("Hello \x0057orld!"); // hexadecimal
            Console.WriteLine("Hello \u0057orld!"); // unicode
            Console.WriteLine("Hello \U00000057orld!"); // unicode
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // unicode in Japanese lol

            // Verbatim string literal
            Console.WriteLine(@"Verbatim string literals (using @) will ignore all escape sequences, except for double quotes.");
            Console.WriteLine(@"Hello\nWorld!"); // new line

            // String concatenation
            string firstName = "Alejandro";
            Console.WriteLine("Hello " + firstName + "!");
            // String interpolation
            Console.WriteLine("Hello {0}!", firstName);
            Console.WriteLine($"Hello {firstName}!");
            // combine with verbatim string literal
            Console.WriteLine($@"Hello \{firstName}\!");

            // questions review
            // firstName = firstName + '\'; // error; backslash is an escape character
            firstName = firstName + '\\'; // ok
            firstName = firstName + @"\"; // ok

        }

    }

}