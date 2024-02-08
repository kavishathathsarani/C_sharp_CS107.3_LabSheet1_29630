using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    /* Write a Console Application program to calculate the sum of all numbers from 1 to a given positive integer
      Prompt the user to enter a positive integer and display the sum
      If the user inputs a negative value it should display “ERROR
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number ");
                int num = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                {
                    if (num <= 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        for (int i = 1; i <= num; i++)
                        {
                            sum += i;
                        }
                    }
                }
                Console.WriteLine("The sum all numbers " + sum);
                Console.ReadLine();
            }
        }
    }
}