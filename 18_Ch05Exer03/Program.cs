using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Ch05Exer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string: ");
            string myS = Console.ReadLine();
            char[] separator = { ' ' };
            string[] mySArray = myS.Split(separator);
            string newS = "";

            foreach (string s in mySArray)
            {
                newS += $"\"{s}\" ";
            }
            newS = newS.TrimEnd();
            Console.WriteLine(newS);
        }
    }
}
