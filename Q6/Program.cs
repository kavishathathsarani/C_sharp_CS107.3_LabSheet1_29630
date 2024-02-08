using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    /*Create a C# console application that prompts the user to input a student's name and their exam marks
      Based on the provided marks, determine, and display the corresponding grade for the student
     The grading scale is as follows:
•	If the marks are between 75 and 100 (inclusive), assign Grade A.
•	For marks between 60 and 74 (inclusive), assign Grade B.
•	For marks between 50 and 59 (inclusive), assign Grade C.
•	For marks between 40 and 49 (inclusive), assign Grade D.
•	If the marks are below 40, the student has failed.
•	Display the student's name along with their assigned grade at the end of the program.
•	Validate the user input so that when the user inputs a value
    higher than 100 and less than 0 it displays an error message
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name  ");
            string studentName = Console.ReadLine();

            int marks;
            do
            {
                Console.Write("Enter exam marks  ");
                while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid");
                }
                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid");
                }
            } while (marks < 0 || marks > 100);

            string grade;
            if (marks >= 75 && marks <= 100)
            {
                grade = "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine($"Student Name {studentName}");
            Console.WriteLine($"Grade {grade}");
            Console.ReadLine();
        }
    }
}