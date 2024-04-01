using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Ch05Exer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            string input = Console.ReadLine();
            char[] myCharArray = input.ToCharArray();
            string outS = "";

            for (int i = myCharArray.Length - 1; i >= 0; i--)
            {
                outS += myCharArray[i];
            }
            Console.WriteLine($"Reversed: {outS}");
        }
    }
}
