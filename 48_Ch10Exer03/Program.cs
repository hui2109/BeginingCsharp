using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _44_Ch10CardLib;

namespace _48_Ch10Exer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Deck playDeck = new Deck();
                playDeck.Shuffle();
                bool isFlush = false;
                int flushHandIndex = 0;

                for (int hand = 0; hand < 10; hand++)
                {
                    isFlush = true;
                    Suit flushSuit = playDeck.GetCard(hand * 5).suit;
                    for (int card = 1; card < 5; card++)
                    {
                        if (playDeck.GetCard(hand * 5 + card).suit != flushSuit)
                        {
                            isFlush = false;
                            break;
                        }
                    }
                    if (isFlush)
                    {
                        flushHandIndex = hand * 5;
                        break;
                    }

                }

                if (isFlush)
                {
                    Console.WriteLine("Flush!");
                    for (int card = 0; card < 5; card++)
                    {
                        Console.WriteLine(playDeck.GetCard(flushHandIndex + card));
                    }
                }
                else
                {
                    Console.WriteLine("No flush.");
                }

                break;
            }

        }
    }
}
