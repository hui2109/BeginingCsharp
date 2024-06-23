﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _51_Ch11CardLib
{
    public class Card : ICloneable
    {
        public readonly Rank rank;
        public readonly Suit suit;

        private Card()
        {
            throw new System.NotImplementedException();
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString() => "The " + rank + " of " + suit + "s";

        public object Clone() => MemberwiseClone();
    }
}