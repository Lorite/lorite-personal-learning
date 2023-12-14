using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P5M04ProjectPlanAPettingZooVisit {

    public static class Program {

        public static void Main() {
            // You're developing an application for the Contoso Petting Zoo that coordinates school visits. The Contoso Petting Zoo is home to 18 different species of animals. At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. After visiting their set of animals, the students will rotate groups until they've seen all the animals at the petting zoo.

            // By default, the students are divided into 6 groups. However, there are some classes that have a small or large number of students, so the number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, so as to keep the experience unique.

            // The design specification for the Contoso Petting Zoo application is as follows:

            //     There are currently three visiting schools
            //         School A has six visiting groups (the default number)
            //         School B has three visiting groups
            //         School C has two visiting groups

            //     For each visiting school, perform the following tasks
            //         Randomize the animals
            //         Assign the animals to the correct number of groups
            //         Print the school name
            //         Print the animal groups

            string[] pettingZoo = {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6) {
                RandomizeAnimals();
                string[,] group = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group);
            }

            void RandomizeAnimals() {
                Random random = new Random();
                for (int i = 0; i < pettingZoo.Length; i++) {
                    int randomIndex = random.Next(i, pettingZoo.Length);
                    string temp = pettingZoo[randomIndex];
                    pettingZoo[randomIndex] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groupCount = 6) {
                int groupSize = pettingZoo.Length / groupCount;
                string[,] group = new string[groupCount, groupSize];
                int groupIndex = 0;
                int pettingZooIndex = 0;
                for (int i = 0; i < pettingZoo.Length; i++) {
                    group[groupIndex, pettingZooIndex] = pettingZoo[i];
                    pettingZooIndex++;
                    if (pettingZooIndex == groupSize) {
                        groupIndex++;
                        pettingZooIndex = 0;
                    }
                }
                return group;
            }

            void PrintGroup(string[,] group) {
                for (int i = 0; i < group.GetLength(0); i++) {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < group.GetLength(1); j++) {
                        Console.Write($"\t{group[i, j].PadRight(10)}");
                    }
                    Console.WriteLine();
                }
            }

        }

    }

}