using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predefined numbers
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before swapping: a = {a}, b = {b}");

            // Swap numbers without using a third variable
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}
