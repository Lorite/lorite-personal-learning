using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M02AddDecisionLogic {

    public static class Program {

        public static void Main() {
            // In this exercise, you'll practice writing if statements by creating a game. First you'll define the rules of the game, then you'll implement them in code.
            // You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.
            // If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
            // If all three dice you roll result in the same value, you get six bonus points for rolling triples.
            // If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

            // Set up the game
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;


            // Exercise - Create nested decision logic with if
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (roll1 == roll2 && roll2 == roll3) {
                Console.WriteLine("You rolled triples! +6 bonus points!");
                total += 6;
            }
            if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3) {
                Console.WriteLine("You rolled doubles! +2 bonus points!");
                total += 2;
            }

            if (total >= 15) {
                Console.WriteLine("You got more than 15 points. You win!");
            }
            if (total < 15) {
                Console.WriteLine("Sorry, you got less than 15 points. You lose.");
            }


            // Exercise - Create nested decision logic with if, else if, and else
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
                if ((roll1 == roll2) && (roll2 == roll3)) {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                } else {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16) {
                Console.WriteLine("You win a new car!");
            } else if (total >= 10) {
                Console.WriteLine("You win a new laptop!");
            } else if (total == 7) {
                Console.WriteLine("You win a trip for two!");
            } else {
                Console.WriteLine("You win a kitten!");
            }


            // -------------------

            // Challenge: Improve renewal rate of subscriptions
            // You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software.
            // Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end.
            // You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.
            // Rule 1: Your code should only display one message. The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.
            // Rule 2: If the user's subscription will expire in 10 days or less, display the message:  "Your subscription expires soon. Renew now!". The discount percentage is 0%.
            // Rule 3: If the user's subscription will expire in 5 days or less, display the message:  "Your subscription expires in n days. Renew now!" where n is the number of days until the subscription expires. The discount percentage is 10%.
            // Rule 4: If the user's subscription will expire in one day, display the messages: "Your subscription expires in 1 day. Renew now!". The discount percentage is 20%.
            // Rule 5: If the user's subscription has already expired, display the message: "Your subscription has expired. Renew now!". The discount percentage is 0%.
            // Rule 6: If the user's subscription doesn't expire in 10 days or less, display the message: "Your subscription is active." The discount percentage is 0%.
            // Rule 7: Also display the discount percentage in the message. For example, if the user's subscription will expire in 5 days, display the message: "Your subscription expires in 5 days. Renew now! Discount: 10%."


            // Set up the program
            Random random = new Random();
            int daysUntilExpiration = random.Next(13);
            int discountPercentage = 0;
            Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

            // Exercise - Create nested decision logic with if, else if, and else
            if (daysUntilExpiration <= 10) {
                if (daysUntilExpiration == 0) {
                    Console.Write("Your subscription has expired.");
                } else if (daysUntilExpiration == 1) {
                    discountPercentage = 20;
                    Console.Write("Your subscription expires within a day!");
                } else if (daysUntilExpiration <= 5) {
                    discountPercentage = 10;
                    Console.Write($"Your subscription expires in {daysUntilExpiration} days.");
                } else {
                    Console.Write("Your subscription will expire soon.");
                }
                Console.WriteLine(" Renew now!");
                if (discountPercentage > 0) {
                    Console.WriteLine($"Discount: {discountPercentage}%.");
                }
            } else {
                Console.WriteLine("Your subscription is active.");
            }
        }

    }
}