using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Ch04Exer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numberOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            while (!numberOK)
            {
                Console.WriteLine("Enter 2 numbers, both numbers cannot be greater than.");
                Console.WriteLine("Please enter the first number:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                var2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"The first number entered is {var1} " + $"and the second is {var2}.");
                if ((var1 > 10) ^ (var2 > 10))
                {
                    numberOK = true;
                }

                else
                {
                    Console.WriteLine("Only one number may be greater than 10, " + "Please try again.");
                }

            }
            Console.WriteLine("Press the <ENTER> key to exit.");
        }
    }
}
