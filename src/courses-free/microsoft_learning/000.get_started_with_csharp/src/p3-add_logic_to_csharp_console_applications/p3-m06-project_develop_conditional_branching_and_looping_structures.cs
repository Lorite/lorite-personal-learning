using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M06ProjectDevelopConditionalBranchingAndLoopingStructures {

    public static class Program {

        public static void Main() {
            // Suppose you're a developer who likes to support the local community. You and some of your friends started a business that helps find new homes for stray or abandoned cats and dogs.
            // Your business started off small, with just a couple of strays, but it's starting to grow. You want to create an application that will help you match the animals in your care with people looking for a pet.
            // You've found that it's important to have a detailed description of the animals to share with potential owners.
            // In addition, being able to describe the personality of the dog or cat makes them more appealing to potential owners.
            // You decide to create an application that helps you manage information about the dogs and cats you're caring for.
            // Specifications:
                // Create a C# console application.
                // Store application data in a multidimensional string array named ourAnimals.
                // The ourAnimals array includes the following "pet characteristics" for each animal:
                //     Pet ID #.
                //     Pet species (cat or dog).
                //     Pet age (years).
                //     A description of the pet's physical condition/characteristics.
                //     A description of the pet's personality.
                //     The pet's nickname.
                // Implement a sample dataset that represents dogs and cats currently in your care.
                // Display menu options to access the main features of the application.
                // The main features enable the following tasks:
                //     List the pet information for all animals in the ourAnimals array.
                //     Add new animals to the ourAnimals array. The following conditions apply:
                //         The pet species (dog or cat) must be entered when a new animal is added to the ourAnimals array.
                //         A pet ID must be programmatically generated when a new animal is added to the ourAnimals array.
                //         Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
                //         An animal's nickname and personality may be unknown when a pet first arrives.
                //     Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.
                //     Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).
                //     Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).
                //     Edit an animal’s personality description (a pet may behave differently after spending more time in our care).
                //     Display all cats that meet user specified physical characteristics.
                //     Display all dogs that meet user specified physical characteristics.
            // An initial version of the application has already been completed. The Starter code project for this Guided project module includes a Program.cs file that provides some features

            // Build sample data and menu selection loops
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++) {
                switch (i) {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            do {
                // display the top-level menu options

                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null) {
                    menuSelection = readResult.ToLower();
                    // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
                    //  use a conditional statement below that only processes the valid entry values, so the do statement 
                    //  is not required here. 
                }

                // use switch-case to process the selected menu option
                switch (menuSelection) {
                    case "1":
                        // List all of our current pet information
                        for (int i = 0; i < maxPets; i++) {
                            if (ourAnimals[i, 0] != "ID #: ") {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++) {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        string anotherPet = "y";
                        int petCount = 0;
                        for (int i = 0; i < maxPets; i++) {
                            if (ourAnimals[i, 0] != "ID #: ") {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets) {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets) {
                            bool validEntry = false;
                            
                            // get species (cat or dog) - string animalSpecies is a required field 
                            do {
                                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalSpecies = readResult.ToLower();
                                    if (animalSpecies != "dog" && animalSpecies != "cat") {
                                        //Console.WriteLine($"You entered: {animalSpecies}.");
                                        validEntry = false;
                                    } else {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                            // get the pet's age. can be ? at initial entry.
                            do {
                                int petAge;
                                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalAge = readResult;
                                    if (animalAge != "?") {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    } else {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                            do {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "") {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (animalPhysicalDescription == "");

                            // get a description of the pet's personality - animalPersonalityDescription can be blank.
                            do {
                                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalPersonalityDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "") {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (animalPersonalityDescription == "");

                            // get the pet's nickname. animalNickname can be blank.
                            do {
                                Console.WriteLine("Enter a nickname for the pet");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalNickname = readResult.ToLower();
                                    if (animalNickname == "") {
                                        animalNickname = "tbd";
                                    }
                                }
                            } while (animalNickname == "");

                            // store the pet information in the ourAnimals array (zero based)
                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                            petCount = petCount + 1;

                            // check maxPet limit
                            if (petCount < maxPets) {
                                // another pet?
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                                do {
                                    readResult = Console.ReadLine();
                                    if (readResult != null) {
                                        anotherPet = readResult.ToLower();
                                    }

                                } while (anotherPet != "y" && anotherPet != "n");
                            }
                        }

                        if (petCount >= maxPets) {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        // Ensure animal nicknames and personality descriptions are complete
                        Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "5":
                        // Edit an animal’s age");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "6":
                        // Edit an animal’s personality description");
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    
                    case "7":
                        // Display all cats with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    case "8":
                        // Display all dogs with a specified characteristic
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "exit");
        }

    }

}