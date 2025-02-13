using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    using System;
    using System.Text;

    public class CardGroup
    {
        private Card[] cards;
        private int numCards;

        public CardGroup()
        {
            cards = new Card[52];
            numCards = 0;
        }
        public int NumCards
        {
            get { return numCards; }
            set { numCards = value; }
        }

        public Card GetCard(int i)
        {
            if (i < 0 || i >= numCards)
            {
                throw new IndexOutOfRangeException("out of range.");
            }
            return cards[i];
        }

        public void SetCard(int i, Card c)
        {
            if (i < 0 || i >= 52)
            {
                throw new IndexOutOfRangeException("out of range.");
            }
            cards[i] = c;
            numCards++;
        }

        public void AddToGroup(Card c)
        {
            if (numCards >= 52)
            {
                throw new InvalidOperationException("Card group is full.");
            }
            cards[numCards] = c;
            numCards++;
        }

        public void MakeWholeDeck()
        {
            if (numCards > 0)
            {
                throw new InvalidOperationException("Card group is not empty.");
            }
            string[] suits = { "H", "D", "C", "S" };
            foreach (string suit in suits)
            {
                Card facecard = new Card("A" , suit);
                AddToGroup(facecard);
                for (int i = 2; i < 11; i++)
                {
                    Card card = new Card((i).ToString(), suit);
                    AddToGroup(card);
                }
                facecard = new Card("J", suit);
                AddToGroup(facecard);
                facecard = new Card("Q", suit);
                AddToGroup(facecard);
                facecard = new Card("K", suit);
                AddToGroup(facecard);
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = numCards;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealTopCard()
        {
            if (numCards == 0)
            {
                throw new InvalidOperationException("Card group is empty.");
            }
            Card topCard = cards[0];
            for (int i = 1; i < numCards; i++)
            {
                cards[i - 1] = cards[i];
            }
            numCards--;
            return topCard;
        }

        public override string ToString()
        {
            string groupCards = "";
            for (int i = 0; i < numCards; i++)
            {
                groupCards += cards[i].ToString() + " ";
            }
            return groupCards;
        }
    }

}
