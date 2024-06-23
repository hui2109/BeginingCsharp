﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _51_Ch11CardLib;

namespace _52_Ch11CardClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());

                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }

            Console.WriteLine("\nTest for deep copy.\n");
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            Console.WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");

            deck1.Shuffle();

            Console.WriteLine("Original deck shuffled.");
            Console.WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
        }
    }
}
