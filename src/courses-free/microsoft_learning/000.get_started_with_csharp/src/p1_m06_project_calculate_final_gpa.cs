using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P1M06ProjectCalculateFinalGpa {

    public static class Program {

        public static void Main() {
            /* Statement:
            Developers perform some tasks nearly every day. Tasks including declaring string and numeric variables, assigning and extracting values, and performing calculations are not only routine, but essential. Equally important is the task of communicating results to the application user. Mastering the ability to apply these skills to solve a given problem is something that every developer must learn to do.
            Suppose you're a teacher's assistant at a university. You're tasked with developing an application that helps calculate students' grade point average. The application uses the students' grades and credit hours taken to calculate their overall GPA. You're also provided a required format for reporting the students' GPA.
            This module will guide you through the steps required to develop your GPA Calculator application. Your code will declare and assign values to variables based on course information, perform various numeric calculations, and format and display the results. Calculations include determining the sum of the grade points earned and total credit hours. To display the results in the required format, you'll need to manipulate a decimal value to display a total of three digits. You'll also use Console.WriteLine() methods as well character escape sequences that help to format your results.
            By the end of this module, you'll be able to write code that uses various variable types, performs numeric calculations, and displays formatted data for the user.

            You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:
                You're given the student's name and class information.  
                Each class has a name, the student's grade, and the number of credit hours for that class.
                Your application needs to perform basic math operations to calculate the GPA for the given student.
                Your application needs to output/display the student’s name, class information, and GPA.
            To calculate the GPA:
                Multiply the grade value for a course by the number of credit hours for that course.
                Do this for each course, then add these results together.
                Divide the resulting sum by the total number of credit hours.

            Input:
                Student: Sophia Johnson

                Course          Grade   Credit Hours	
                English 101         4       3
                Algebra 101         3       3
                Biology 101         3       4
                Computer Science I  3       4
                Psychology 101      4       3

            Output:
                Final GPA:          3.35
            */

            // Declare variables
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            // Calculate the GPA
            int gradeA = 4;
            int gradeB = 3;
            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalGradePoints = 0;
            totalGradePoints += course1Grade * course1Credit;
            totalGradePoints += course2Grade * course2Credit;
            totalGradePoints += course3Grade * course3Credit;
            totalGradePoints += course4Grade * course4Credit;
            totalGradePoints += course5Grade * course5Credit;

            int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            double gpa = (double)totalGradePoints / totalCreditHours;

            int leadingDigit = (int) gpa;
            int firstDigit = (int) (gpa * 10 ) % 10;
            int secondDigit = (int) (gpa * 100 ) % 10;

            // Print the results
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine();
            Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");
            Console.WriteLine();
            Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
        }

    }

}