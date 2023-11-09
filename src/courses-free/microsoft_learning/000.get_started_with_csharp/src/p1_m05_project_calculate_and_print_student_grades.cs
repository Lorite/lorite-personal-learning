using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P1M05ProjectCalculateAndPrintStudentGrades {

    public static class Program {

        public static void Main() {
            /* Statement:
            Developers perform some tasks nearly every day. Tasks including declaring string and numeric variables, assigning and extracting values, and performing calculations are routine, but essential. Equally important is the task of communicating results to the application user. Mastering the ability to apply these skills to solve a given problem is something that every developer must learn to do.
            Suppose you are a teacher's assistant at a school. You're tasked with developing an application that automates student grading. The application uses all of the scored assignments for each student to calculate their current overall grade/score for the class. The teacher has also provided a required format for reporting the student grades.
            This module will guide you through the steps required to develop your Student Grading application. Your code will declare and assign values to variables based on student names, perform various numeric calculations, and display the results. Calculations include determining the sum of assignment scores and calculating the current grade for each student. To display the results in the required format, you'll use Console.WriteLine(), as well character escape sequences that will help format your results.
            By the end of this module, you'll be able to write code that uses various variable types, performs numeric calculations, and displays formatted data for the user.

            You're given a short list of four students and their five assignment grades.
            Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
            Final scores are calculated as an average of the five assignment scores.
            Your application needs to perform basic math operations to calculate the final grades for each student.
            Your application needs to output/display each student’s name and final score.

            Input:
            Sophia: 93, 87, 98, 95, 100
            Nicolas: 80, 83, 82, 88, 85
            Zahirah: 84, 96, 73, 85, 79
            Jeong: 90, 92, 98, 100, 97

            Output:
            Student     Grade
            Sophia      94.6  A
            Nicolas     83.6  B
            Zahirah     83.4  B
            Jeong       95.4  A
            */

            // Declare variables
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;


        }

    }

}