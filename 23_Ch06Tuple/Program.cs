using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ch06Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(string));

            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = GetMaxMin(numbers);
            Console.WriteLine($"The type of \"result\" is {result.GetType().FullName}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Max number is {result.max}, " + $"Min number is {result.min}, " + $"Average is {result.average}");
        }

        private static (int max, int min, double average) GetMaxMin(IEnumerable<int> numbers)
        {
            return (Enumerable.Max(numbers),
                    Enumerable.Min(numbers),
                    Enumerable.Average(numbers));
        }

    }
}
