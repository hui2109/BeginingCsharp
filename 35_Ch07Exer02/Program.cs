using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Ch07Exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orientation myDirection = (Orientation)1;
            for (byte myByte = 2; myByte < 10; myByte++)
            {
                try
                {
                    myDirection = checked((Orientation)myByte);
                    if ((myDirection < Orientation.North) || (myDirection > Orientation.West))
                    {
                        throw new ArgumentOutOfRangeException("mybyte", myByte, "Value must be between 1 and 4.");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("xx " + e.Message + " yy");
                    Console.WriteLine("Assigning default value, Orientation.North");
                    //myDirection = Orientation.North;
                }
                Console.WriteLine($"myDirection = {myDirection}");
            }
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
