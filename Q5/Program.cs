using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    /*Write a Console Application program to display the multiplication table of a given number
      Prompt the user to enter a number and display its multiplication table. (Use loops
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplication Table for " + number + ":");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + (number * i));
                    Console.ReadLine();
                }
            }
        }


    }
}