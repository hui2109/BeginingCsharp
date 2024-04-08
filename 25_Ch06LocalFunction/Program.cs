using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Ch06LocalFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 5;
            Console.WriteLine($"Main Function  = {myNumber}");
            DoubleIt(ref myNumber);
            Console.WriteLine($"Main Function  = {myNumber}");

            void DoubleIt(ref int val)
            {
                val *= 2;
                Console.WriteLine($"Local Function = {val}");
            }
        }
    }
}
