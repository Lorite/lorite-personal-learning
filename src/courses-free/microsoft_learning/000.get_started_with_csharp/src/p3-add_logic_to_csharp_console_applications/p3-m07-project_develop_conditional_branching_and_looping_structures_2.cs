using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P3M07ProjectDevelopConditionalBranchingAndLoopingStructures2 {

    public static class Program {

        public static void Main() {
            // Suppose you're a developer working on the Contoso Pets application, an application that's used to find homes for stray or abandoned pets.
            // Some of the development work has already been completed.
            // For example, the application's main menu and the code used to store new pet information have been developed.
            // However, certain information isn't always available when a pet is entered in your system.
            // You need to develop the features that ensure a complete dataset exists for each animal in your care.
            // Specifications:
                //     The code declares variables used to collect and process pet data and menu item selections
                //     The code declares the ourAnimals array that includes the following information for each animal in the array:
                //         Pet ID #.
                //         Pet species (cat or dog).
                //         Pet age (years).
                //         A description of the pet's physical appearance.
                //         A description of the pet's personality.
                //         The pet's nickname.
                //     The code uses a for loop around a switch-case construct to populate elements of the ourAnimals array.
                //     The code includes a loop around a main menu that terminates when the user enters "exit". The main menu includes:
                //         List all of our current pet information.
                //         Assign values to the ourAnimals array fields.
                //         Ensure animal ages and physical descriptions are complete.
                //         Ensure animal nicknames and personality descriptions are complete.
                //         Edit an animal’s age.
                //         Edit an animal’s personality description.
                //         Display all cats with a specified characteristic.
                //         Display all dogs with a specified characteristic.
                //     Enter menu item selection or type "Exit" to exit the program
                //     The code reads the user's menu item selection and uses a switch statement to branch the code for each menu item number.
                //     The code includes implementation for menu options 1 and 2.
                //     The code displays an "under construction" message for menu options 3-8.
                // Your goal in this challenge is to create the app features aligned with menu options 3 and 4.
            // To ensure that animal ages and physical descriptions are complete, your code must:
            //     Assign a valid numeric value to petAge for any animal that has been assigned data in the ourAnimals array but has not been assigned an age.
            //     Assign a valid string to petPhysicalDescription for any animal that has been assigned data in the ourAnimals array but has not been assigned a physical description.
            //     Verify that physical descriptions have an assigned value. Assigned values cannot have zero characters. Any further requirement is up to you.
            // To ensure that animal nicknames and personality descriptions are complete, your code must:
            //     Assign a valid string to petNickname for any animal that has been assigned data in the ourAnimals array but has not been assigned a nickname.
            //     Assign a valid string to petPersonalityDescription for any animal that has been assigned data in the ourAnimals array but has not been assigned a personality description.
            //     Verify that nicknames and personality descriptions have an assigned value. Assigned values cannot have zero characters. Any further requirement is up to you.

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
            int petCount = 0;
            string anotherPet = "y";
            bool validEntry = false;
            int petAge = 0;

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

            // display the top-level menu options
            do {
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
                                    Console.WriteLine(ourAnimals[i, j].ToString());
                                }
                            }
                        }
                        Console.WriteLine("\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "2":
                        // Add a new animal friend to the ourAnimals array
                        //
                        // The ourAnimals array contains
                        //    1. the species (cat or dog). a required field
                        //    2. the ID number - for example C17
                        //    3. the pet's age. can be blank at initial entry.
                        //    4. the pet's nickname. can be blank.
                        //    5. a description of the pet's physical appearance. can be blank.
                        //    6. a description of the pet's personality. can be blank.

                        anotherPet = "y";
                        petCount = 0;
                        for (int i = 0; i < maxPets; i++) {
                            if (ourAnimals[i, 0] != "ID #: ") {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets) {
                            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets) {
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


                            // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                            do {
                                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null) {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "") {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);


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
                            } while (validEntry == false);


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
                            } while (validEntry == false);

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
                            //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
                        }

                        if (petCount >= maxPets) {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;

                    case "3":
                        // Ensure animal ages and physical descriptions are complete
                        //
                        //    ourAnimals[i, 2] = "Age: " + animalAge;
                        //    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

                        for (int i = 0; i < maxPets; i++) {
                            if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ") {
                                do {
                                    Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null) {
                                        animalAge = readResult;
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 2] = "Age: " + animalAge.ToString();
                            }

                            if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ") {
                                do {
                                    Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null) {
                                        animalPhysicalDescription = readResult.ToLower();
                                        if (animalPhysicalDescription == "") {
                                            validEntry = false;
                                        } else {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);

                                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            }
                        }
                        Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();

                        break;

                    case "4":
                        // Ensure animal nickname and personality descriptions are complete
                        //
                        //    ourAnimals[i, 3] = "Nickname: " + animalNickname;
                        //    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                        for (int i = 0; i < maxPets; i++) {
                            if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ") {
                                do {
                                    Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null) {
                                        animalNickname = readResult;
                                        if (animalNickname == "") {
                                            validEntry = false;
                                        } else {
                                            validEntry = true;
                                        }

                                    }

                                } while (validEntry == false);

                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                            }

                            if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ") {
                                do {
                                    //"Enter a description of the pet's personality (likes or dislikes, tricks, energy level"
                                    Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null) {
                                        animalPersonalityDescription = readResult.ToLower();
                                        if (animalPersonalityDescription == "") {
                                            validEntry = false;
                                        } else {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);

                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            }
                        }
                        Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
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