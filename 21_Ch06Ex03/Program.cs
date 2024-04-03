﻿using System;

namespace _21_Ch06Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine($"Summed Values = {sum}");
        }

        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
    }
}
