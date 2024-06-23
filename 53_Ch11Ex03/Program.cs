using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _53_Ch11Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2To1000 = new Primes(2, 10000000);
            foreach (long i in primesFrom2To1000)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
