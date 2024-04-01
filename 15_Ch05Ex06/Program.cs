using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Ch05Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
