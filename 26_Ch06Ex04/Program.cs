using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ch06Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command line arguments were specified:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
