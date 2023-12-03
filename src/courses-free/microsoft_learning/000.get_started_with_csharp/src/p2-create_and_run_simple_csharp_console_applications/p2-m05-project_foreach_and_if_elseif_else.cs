using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M05ProjectForeachAndIfElseifElse {

    public static class Program {

        public static void Main() {
            // Suppose you're a teacher's assistant at a school. You've been working with a teacher to create an application that automates the grading process. Your C# programming skills have increased since you completed the initial version of your application.
            // The teacher has asked you to update your application. The updates focus on using arrays, foreach statements, and if statements. The teacher also wants you to include extra credit assignments in your calculations of the final grades.

            // In this module, you'll be guided through the process of updating your Student Grading application.
            // You'll use arrays to store student names and the scores of graded assignments, and you'll use foreach statements to iterate through array values. Each student's final grade will be calculated inside a foreach code block.
            // You'll use an if statement to assign a final letter grade. Your completed application will output student grades using the teacher's score report specification.

            // Start with four students. Each student has five exam scores.
            // Each exam score is an integer value, 0-100, where 100 represents 100% correct.
            // A student's overall exam score is the average of their five exam scores.
            // Criteria for extra credit assignments:
            //      Include extra credit assignment scores in the student's scores array.
            //      Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
            //      Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
            // Your application needs to automatically assign letter grades based on the calculated final score for each student.
            // Your application needs to output/display each student’s name and formatted grade.
            // Your application needs to support adding other students and scores with minimal impact to the code.

            // You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:
            //     The code declares variables used to define student names and individual exam scores for each student.
            //     The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
            //     The code includes a hard coded letter grade that the developer must apply manually.
            //     The code includes Console.WriteLine() statements to display the student grading report.

            // Your goal is to update the existing code to include the following features:
            //     Use arrays to store student names and assignment scores.
            //     Use a foreach statement to iterate through the student names as an outer program loop.
            //     Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.
            //     Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
            //     Use an updated algorithm within the outer loop to calculate the average exam score for each student.
            //     Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
            //     Integrate extra credit scores when calculating the student's final score and letter grade as follows:
            //         Your code must detect extra credit assignments based on the number of elements in the student's scores array.
            //         Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.


            // Declare variables and set their initial values.
            int examAssignments = 5;
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
            
            string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";

            // Use a foreach statement to iterate through the student names as an outer program loop.
            Console.WriteLine("Student\t\tGrade\n");
            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;
                int gradedAssignments = 0;

                foreach (int score in studentScores) {
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        sumAssignmentScores += score;
                    else
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

        }

    }
}