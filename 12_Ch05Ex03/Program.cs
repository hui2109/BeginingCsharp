using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Ch05Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) South\n3) East\n4) West");

            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));

            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToDouble(Console.ReadLine());

            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} " + $"and a distance of {myRoute.distance}.");
        }
    }

    enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }

    struct route
    {
        public Orientation direction;
        public double distance;
    }
}
