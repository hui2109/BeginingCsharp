using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _51_Ch11CardLib
{
    public class CardCollection : CollectionBase, ICloneable
    {
        public void Add(Card newCard) => List.Add(newCard);
        public void Remove(Card oldCard) => List.Remove(oldCard);
        public Card this[int cardIndex]
        {
            get => (Card)List[cardIndex];
            set { List[cardIndex] = value; }
        }

        public void CopyTo(CardCollection targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card) => InnerList.Contains(card);

        public object Clone()
        {
            CardCollection newCards = new CardCollection();
            foreach (Card sourceCard in List)
            {
                //newCards.Add((Card)sourceCard.Clone());
                newCards.Add(sourceCard);
            }
            return newCards;
        }
    }
}
