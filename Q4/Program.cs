using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    /* Write a Console Application program to print the first N terms of the Fibonacci series
      Prompt the user to enter the value of N (Use recursion)
     */
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
                Console.ReadLine();
            }
        }
    }
}