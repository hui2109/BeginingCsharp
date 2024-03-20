using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ch03Exer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Please input first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input third number:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input fourth number:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The product of {a}, {b}, {c} and {d} is :" + $"{a * b * c * d}.");
        }
    }
}
