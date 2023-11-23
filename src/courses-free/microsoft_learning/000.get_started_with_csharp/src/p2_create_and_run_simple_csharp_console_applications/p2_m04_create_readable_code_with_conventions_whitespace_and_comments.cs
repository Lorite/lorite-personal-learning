using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M04CreateReadableCodeWithConventionsWhitespaceAndComments {

    public static class Program {

        public static void Main() {
            // A software developer once famously said, "The hardest part of software development is naming things."
            // Not only does the name of a variable have to follow certain syntax rules, it should also be used to make the code more human-readable and understandable. That's a lot to ask of one line of code!
            // LOL??????????

            // Variable name rules 
            // Variable names can contain alphanumeric characters and the underscore character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
            // Variable names must begin with an alphabetical letter or an underscore, not a number. Developers use the underscore for a special purpose, so try to not use that for now.
            // Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
            // Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

            // Local variable name conventions
            // Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. >For example: string thisIsCamelCase;.
            // Variable names should be descriptive and meaningful in your application. You should choose a name for your variable that represents the kind of data it will hold (not the data type). >For example: bool orderComplete;, NOT bool isComplete;.
            // Variable names should be one or more entire words appended together. Don't use contractions because the name of the variable may be unclear to others who are reading your code. >For example: decimal orderAmount;, NOT decimal odrAmt;.
            // Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strMyValue;. It was a popular style years ago. However, most developers don't follow this advice anymore and there are good reasons not to use it.

            // Local variable name examples
            char userOption;
            int gameScore;
            float particlesPerMillion;
            bool processedCustomer;

            // Code comments
            // Comments are used to document your code. They are ignored by the compiler.
            // Adding a message like TODO to remind you to look at a given passage of code later. >For example: // TODO: Add code to calculate the total price.
            // Block comments are used to document a section of code. >For example:
            /* This block of code
             calculates the total price.
             */
            
            // Use whitespace to make your code more readable
            // Whitespace is the space between characters in your code. It includes spaces, tabs, and line breaks.
            // C# does not care about whitespace. It is ignored by the compiler. So you could write your code like this:
            int firstNumber=12;int secondNumber=7;Console.WriteLine(firstNumber+secondNumber);
            // But that would be hard to read. Instead, you should use whitespace to make your code more readable. For example:
            int firstNumber2 = 12;
            int secondNumber2 = 7;
            Console.WriteLine(firstNumber2 + secondNumber2);
            // Some people like to use tabs to indent their code. Others like to use spaces. It doesn't matter which one you use, as long as you are consistent.
            // Some people prefer to add vertical whitespace for loops and if statements, but it depends on your personal preference. The execution speed of the code is the same either way.
            // Code should be self explanatory. If you need to add a comment to explain what the code is doing, then you should probably refactor your code to make it more readable.

            // Exercise: Improve the readability of the code
            string str = "The quick brown fox jumps over the lazy dog.";
            // convert the message into a char array
            char[] charMessage = str.ToCharArray();
            // Reverse the chars
            Array.Reverse(charMessage);
            int x = 0;
            // count the o's
            foreach (char i in charMessage) { if (i == 'o') { x++; } }
            // convert it back to a string
            string new_message = new String(charMessage);
            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");

            // Improved readability of the code
            string originalMessage = "The quick brown fox jumps over the lazy dog.";
            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);
            int letterCount = 0;
            foreach (char letter in message) {
                if (letter == 'o') {
                    letterCount++;
                }
            }
            string newMessage = new String(message);
            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");

        }

    }
}