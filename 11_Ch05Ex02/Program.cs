using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Ch05Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;

            Orientation myDirection = Orientation.North;
            Console.WriteLine($"myDirection = {myDirection}");

            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);

            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.WriteLine($"string equivalent = {myDirection.ToString()}");
        }
    }

    enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }
}
