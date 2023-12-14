using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P4M05ModifyTheContentOfStringsUsingBuiltInStringDataTypeMethods {

    public static class Program {

        public static void Main() {
            // String - IndexOf()
            string message = "Find what is (inside the parentheses)";
            int openingPosition = message.IndexOf('('); // IndexOf() returns the index of the first occurrence of the specified character in the string. If the character is not found, it returns -1.
            int closingPosition = message.IndexOf(')');
            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            // String - Substring()
            openingPosition += 1;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length)); // Substring() returns a new string that is a substring of the original string. It takes two parameters: the starting index and the length of the substring.
        
            // String - IndexOfAny()
            string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition2 = message2.LastIndexOf('(');
            openingPosition2 += 1;
            int closingPosition2 = message2.LastIndexOf(')');
            int length2 = closingPosition2 - openingPosition2;
            Console.WriteLine(message2.Substring(openingPosition2, length2));

            // Retrieve all instances of substring inside parentheses
            while (true) {
                int openingPosition2Temp = message2.IndexOf('(');
                if (openingPosition2Temp == -1) break;

                openingPosition2Temp += 1;
                int closingPosition2Temp = message2.IndexOf(')');
                int length2Temp = closingPosition2Temp - openingPosition2Temp;
                Console.WriteLine(message2.Substring(openingPosition2Temp, length2Temp));

                // Note the overload of the Substring to return only the remaining 
                // unprocessed message:
                message2 = message2.Substring(closingPosition2Temp + 1);
            }

            // ------------------------------

            // String - IndexOfAny()
            string message3 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            char[] openSymbols = { '[', '{', '(' };

            int closingPosition3 = 0;
            while (true)
            {
                int openingPosition3 = message3.IndexOfAny(openSymbols, closingPosition3); // The IndexOfAny() helper method requires a char array of characters. 
                if (openingPosition3 == -1) break;

                string currentSymbol = message3.Substring(openingPosition3, 1);
                char matchingSymbol = ' ';
                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                openingPosition3 += 1;
                closingPosition3 = message3.IndexOf(matchingSymbol, openingPosition3);

                int length3 = closingPosition3 - openingPosition3;
                Console.WriteLine(message3.Substring(openingPosition3, length3));
            }

            // String - Remove()
            string message4 = "This is a test of the emergency broadcast system. This is only a test.";
            string search = " test";
            int index = message4.IndexOf(search);
            message4 = message4.Remove(index, search.Length);
            Console.WriteLine(message4);

            // String - Replace()
            string message5 = "This is a test of the emergency broadcast system. This is only a test.";
            string search2 = "test";
            string replace = "trial";
            message5 = message5.Replace(search2, replace);
            Console.WriteLine(message5);

            // ------------------------------
            
            // Challenge to extract, replace, and remove data from an input string
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
            string quantity = "";
            string output = "";

            // Extract the quantity
            int quantityStart = input.IndexOf("<span>");
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
            quantity = $"Quantity: {quantity}";

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div>");
            int divLength = "<div>".Length;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div>");
            int divCloseLength = "</div>".Length;
            output = output.Remove(divCloseStart, divCloseLength);
            output = $"Output: {output}";

            Console.WriteLine(quantity);
            Console.WriteLine(output);

        }

    }

}