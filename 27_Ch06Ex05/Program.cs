﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Ch06Ex05
{
    internal class Program
    {
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;
        delegate double ProcessDelegate(double param1, double param2);

        static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.WriteLine($"Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));

            Console.WriteLine("Enter M to mutiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else
            {
                process = new ProcessDelegate(Divide);
            }
            Console.WriteLine($"Result: {process(param1, param2)}");
        }
    }
}
