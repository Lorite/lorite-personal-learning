using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P2M06ProjectForeachAndIfElseifElse2 {

    public static class Program {

        public static void Main() {
            // End users often ask developers to add new features to an application. User requests indicate that your application is being used, and more importantly, that the customer plans to continue using your application.
            // The customer just wants some features updated. The ability to update an existing application based on user requests is very important.
            // A successful update will preserve the integrity of the original application while providing the user with the improved experience that they requested.

            // Suppose you're a teacher's assistant at a school and that you developed an application to automate the grading process. The application uses arrays to store student names and graded assignments. The application also implements a combination of iteration and selection statements to calculate and report each student's final grade. Your application even differentiates between exam assignments and extra credit assignments when calculating student grades. Although the application does everything that the teacher asked for, you've received a request for new features. The teacher has asked you to update the grading report to show exam and extra credit assignment scores separately from the final numeric score and letter grade.
            // This module challenges you to add new capabilities to your Student Grading application.
            // In short, you need to use the teacher's updated grading report specification to:
                //    update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
                //    update the code that writes the grading report to the console.

            // Project specification
            // The Starter code project for this module is a C# console application that implements the following code features:
                // Uses arrays to store student names and assignment scores. 
                // Uses a foreach statement to iterate through the student names as an outer program loop.
                // Uses an if statement within the outer loop to identify the current student's name and access that student's assignment scores.
                // Uses a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.
                // Uses an algorithm within the outer loop to calculate the average exam score for each student.
                // Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
                // Integrates extra credit scores when calculating the student's final score and letter grade as follows:
                    // Detects extra credit assignments based on the number of elements in the student's scores array.
                    // Applies a 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.
            // Your goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.
            // The current score report lists the student's name followed by the calculated overall grade and letter grade.
            // In addition to the student's final numeric score and letter grade, the teacher wants the updated report to include the exam score and the impact that extra credit work has on the student's final grade.

            int examAssignments = 5;
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
            foreach (string name in studentNames) {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                int gradedAssignments = 0;
                int gradedExtraCreditAssignments = 0;

                int sumExamScores = 0;
                int sumExtraCreditScores = 0;

                decimal currentStudentGrade = 0;
                decimal currentStudentExamScore = 0;
                decimal currentStudentExtraCreditScore = 0;

                foreach (int score in studentScores) {
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments) {
                        sumExamScores = sumExamScores + score;
                    } else {
                        gradedExtraCreditAssignments += 1;
                        sumExtraCreditScores += score;
                    }
                }

                currentStudentExamScore = (decimal)(sumExamScores) / examAssignments; // We use decimal casting to preserve the fractional part of the division.
                currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

                currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

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

                Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
            }

        }

    }
}