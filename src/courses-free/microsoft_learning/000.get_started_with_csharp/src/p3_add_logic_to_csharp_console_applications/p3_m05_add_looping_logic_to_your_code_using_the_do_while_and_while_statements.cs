using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M05AddLoopingLogicToYourCodeUsingTheDoWhileAndWhileStatements {

    public static class Program {

        public static void Main() {
            // do-while statement
            // it is useful,for example, for validating user input
            Random random = new Random();
            int current = 0;
            do {
            // This code executes at least one time
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            Console.WriteLine("Done!");

            // while statement
            current = 0;
            while (current != 7) {
                // This code may not execute at all
                current = random.Next(1, 11);
                Console.WriteLine(current);
            }
            Console.WriteLine("Done!");

            // Use the continue statement to step directly to the Boolean expression
            current = random.Next(1, 11);
            do {
                current = random.Next(1, 11);

                if (current >= 8) continue; // skip the rest of the loop body

                Console.WriteLine(current);
            } while (current != 7);
            Console.WriteLine("Done!");

            // Exercise - Role playing game battle challenge
            // In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys".
            // Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score.
            // Once either character's health reaches zero, they lose the game.
            // In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same health score.
            // During the hero's turn, they'll generate a random value which will be subtracted from the monster's health.
            // If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle will resume.
            int hero = 10;
            int monster = 10;
            Random dice = new Random();
            do {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);
            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            // Summary - different types of loops
            // The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
            // The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
            // The do-while statement: conditionally executes its body one or more times.
            // The while statement: conditionally executes its body zero or more times.

            // Manage user input
            // The following code snippet shows how to use the do-while statement to manage user input.
            string? readResult; // ? is the null-conditional operator
            Console.WriteLine("Enter a string:");
            do {
                readResult = Console.ReadLine();
            } while (readResult == null);
            Console.WriteLine($"You entered: {readResult}");

            // Code project 1 - write code that validates integer input
            int? input;
            readResult = null;
            do {
                Console.WriteLine("Enter a number between 0 and 100:");
                readResult = Console.ReadLine();
                input = int.TryParse(readResult, out int result) ? result : null;
            } while (input == null || input < 0 || input > 100);
            Console.WriteLine($"You entered: {input}");

            // Code project 2 - write code that validates string input
            readResult = null;
            string roleName = "";
            bool validEntry = false;
            do {                
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null) {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") {
                    validEntry = true;
                } else {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);
            Console.WriteLine($"Your input value ({roleName}) has been accepted.");

            // Code project 3 - write code that processes the contents of a string array
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;
            string myString = "";
            int periodLocation = 0;
            for (int i = 0; i < stringsCount; i++) {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");
                string mySentence;
                // extract sentences from each string and display them one at a time
                while (periodLocation != -1) {
                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);
                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);
                    // remove any leading white-space from myString
                    myString = myString.TrimStart();
                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");
                    Console.WriteLine(mySentence);
                }
                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }

        }

    }

}