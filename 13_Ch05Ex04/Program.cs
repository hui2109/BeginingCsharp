using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Ch05Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Mary Chris", "Autry Rual" };
            int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Use foreach loop");
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
        }
    }
}
