using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /* Write a Console Application Program to calculate the area of a rectangle
     Prompt the user to enter the length and width
    Display the calculated area. (use a separate function calculate the area
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the width ");
            int w = Convert.ToInt32(Console.ReadLine());
            CalArea(w, h);
            Console.ReadLine();
        }
        static void CalArea(int length, int height)
        {
            int area;
            area = height * length;
            Console.WriteLine("The area is " + area);
        }
    }
}
