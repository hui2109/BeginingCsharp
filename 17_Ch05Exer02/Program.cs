using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Ch05Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string: ");
            string myInputString = Console.ReadLine();
            string newS = myInputString.Replace("no", "yes");
            Console.WriteLine($"Replace 'no' with 'yes': {newS}");
        }
    }
}
