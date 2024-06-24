﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _51_Ch11CardLib;

namespace _52_Ch11CardClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test for base implemetation.
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

            // Test for deep copy.
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            Console.WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            deck1.Shuffle();
            Console.WriteLine("Original deck shuffled.");
            Console.WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");

            // Test for operators overload
            Card.isAceHigh = true;
            Console.WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            Console.WriteLine("Clubs are trumps");

            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ten);

            Console.WriteLine($"{card1} == {card2} ? {card1 == card2}");
            Console.WriteLine($"{card1} != {card3} ? {card1 != card3}");
            Console.WriteLine($"{card1}.Equals({card4}) ? {card1.Equals(card4)}");
            Console.WriteLine($"Card.Equals({card3}, {card4}) ? {Card.Equals(card3, card4)}");

            Console.WriteLine($"{card1} > {card2} ? {card1 > card2}");
            Console.WriteLine($"{card1} <= {card3} ? {card1 <= card3}");
            Console.WriteLine($"{card1} > {card4} ? {card1 > card4}");
            Console.WriteLine($"{card4} > {card1} ? {card4 > card1}");
            Console.WriteLine($"{card5} > {card4} ? {card5 > card4}");
            Console.WriteLine($"{card4} > {card5} ? {card4 > card5}");


        }
    }
}
