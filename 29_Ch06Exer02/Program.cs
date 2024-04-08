using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Ch06Exer02
{
    internal class Program
    {
        delegate string MyReadLineDelegate();

        static void Main(string[] args)
        {
            MyReadLineDelegate mrld = new MyReadLineDelegate(Console.ReadLine);
            Console.WriteLine("Please input a string:");
            string s = mrld();
            Console.WriteLine($"The string you typed is {s}.");

        }
    }
}
