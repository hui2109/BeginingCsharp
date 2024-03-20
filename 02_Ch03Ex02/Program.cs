using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ch03Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string username;
            Console.WriteLine("Enter your name:");
            username = Console.ReadLine();
            Console.WriteLine($"Welcome {username}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from " + $"{firstNumber} is {firstNumber - secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " + $"is {firstNumber * secondNumber}.");
            Console.WriteLine($"The result of diving {firstNumber} by " + $"{secondNumber} is {firstNumber / secondNumber}.");
            Console.WriteLine($"The remainder after dividing {firstNumber} by " + $"{secondNumber} is {firstNumber % secondNumber}");
        }
    }
}
