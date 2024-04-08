using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Ch06Exer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("The number of params must be 2!");
                return;
            }

            string s = args[0];
            int t = Convert.ToInt32(args[1]);
            Console.WriteLine($"String parameter: {s}");
            Console.WriteLine($"Integer parameter: {t}");
        }
    }
}
