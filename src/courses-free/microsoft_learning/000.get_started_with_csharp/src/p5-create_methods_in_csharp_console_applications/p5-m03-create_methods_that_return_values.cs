using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P5M03CreateMethodsThatReturnValues {

    public static class Program {

        public static void Main() {
            // Methods can provide return values after performing their tasks.
            // By using parameters and return types together, you can create streamlined methods that receive input, perform a task, and provide output.
            // This format allows you to efficiently build functionality into your programs while maintaining clean, readable code.
            // Methods can return any data type, or they can return nothing at all (void). The return type must always be specified before the method name.

            // Use methods to calculate the total purchase price
            double total = 0;
            double minimumSpend = 30.00;

            double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
            double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

            for (int i = 0; i < items.Length; i++) {
                total += GetDiscountedPrice(i);
            }

            total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex) {
                return items[itemIndex] * (1 - discounts[itemIndex]);
            }

            bool TotalMeetsMinimum() {
                return total >= minimumSpend;
            }

            string FormatDecimal(double input) {
                return input.ToString().Substring(0, 5);
            }

            // If the value returned by a method and its return type do not match, the compiler will try to cast it and may throw an exception if it fails.

            // Exercise - Return strings from methods
            // Create a method to reverse a word
            string ReverseWord(string word) {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--) {
                    result += word[i];
                }
                return result;
            }

            string input = "snake";

            Console.WriteLine(input);
            Console.WriteLine(ReverseWord(input));

            // Create a method to reverse words in a sentence
            string ReverseWordsInSentence(string sentence) {
                string[] words = sentence.Split(' ');
                string result = "";
                foreach(string word in words) {
                    result += ReverseWord(word) + " ";
                }
                return result;
            }

            input = "I love C#";

            Console.WriteLine(input);
            Console.WriteLine(ReverseWordsInSentence(input));

            // Return boolean values from methods
            string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};
            Console.WriteLine("Is it a palindrome?");
            foreach (string word in words) {
                Console.WriteLine($"Is {word} palindrome? (method 1): {IsPalindrome(word)}");
                Console.WriteLine($"Is {word} palindrome? (method 2): {IsPalindrome2(word)}");
            }

            bool IsPalindrome(string word) {
                return word == ReverseWord(word);
            }

            bool IsPalindrome2(string word) {
                for (int i = 0; i < word.Length / 2; i++) {
                    if (word[i] != word[word.Length - 1 - i]) {
                        return false;
                    }
                }
                return true;
            }

            // ------------------------------

            // Return arrays from methods
            // Suppose you have several coins of different values. You're tasked to find two coins whose sum is equal to a target value.
            // In this exercise, the coins available are represented in an integer array. You'll need to return the indices of the two coins in a new array.
            int target = 30;
            int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
            int[,] result = TwoCoins(coins, target);
            PrintResult(result);

            int[,] TwoCoins(int[] coins, int target) {
                int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
                int count = 0;

                for (int curr = 0; curr < coins.Length; curr++) {
                    for (int next = curr + 1; next < coins.Length; next++) {
                        if (coins[curr] + coins[next] == target) {
                            result[count, 0] = curr;
                            result[count, 1] = next;
                            count++;
                        }
                        if (count == result.GetLength(0)) {
                            return result;
                        }
                    }
                }
                return (count == 0) ? new int[0,0] : result;
            }

            void PrintResult(int[,] result) {
                if (result.Length == 0) {
                    Console.WriteLine("No two coins make change");
                } else {
                    Console.WriteLine("Change found at positions:");
                    for (int i = 0; i < result.GetLength(0); i++) {
                        if (result[i,0] == -1) {
                            break;
                        }
                        Console.WriteLine($"{result[i,0]},{result[i,1]}");
                    }
                }
            }

            int[,] result2 = TwoCoins(coins, 100);
            PrintResult(result2);

            // ------------------------------
            // Dice mini-game challenge
            // Your challenge is to design a mini-game. The game should select a target number that is a random number between one and five (inclusive). The player must roll a six-sided die. To win, the player must roll a number greater than the target number.
            // At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.
            // In this challenge, you're given some starting code. You must determine what methods to create, their parameters, and their return types.
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay()) {
                PlayGame();
            }

            bool ShouldPlay() {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame() {
                var play = true;

                while (play) {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget() {
                return random.Next(1, 6);
            }

            int RollDice() {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target) {
                if (roll > target) {
                    return "You win!";
                }
                return "You lose!";
            }
        }

    }

}