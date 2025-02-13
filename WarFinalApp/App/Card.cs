using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Card
    {
        private string face;
        private string suit;

        public Card()
        {
            this.face = "A";
            this.suit = "S";
        }

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public string Face
        {
            get { return face; }
            set
            {
                string[] validFaces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
                if (Array.Exists(validFaces, f => f == value))
                {
                    face = value;
                }
                else
                {
                    throw new ArgumentException("Invalid face value.");
                }
            }
        }

        public string Suit
        {
            get { return suit; }
            set
            {
                string[] validSuits = { "H", "D", "C", "S" };
                if (Array.Exists(validSuits, s => s == value))
                {
                    suit = value;
                }
                else
                {
                    throw new ArgumentException("Invalid suit.");
                }
            }
        }

        public override string ToString()
        {
            return face + suit;
        }

        public string FileName()
        {
            string filename = "";

            switch(suit)
            {
                case "D":
                    filename += "diamonds_";
                    break;
                case "C":
                    filename += "clubs_";
                    break;
                case "H":
                    filename += "hearts_";
                    break;
                case "S":
                    filename += "spades_";
                    break;
            }

            switch(face)
            {
                case "A":
                    filename += "ace";
                    break;
                case "J":
                    filename += "jack";
                    break;
                case "K":
                    filename += "king";
                    break;
                case "Q":
                    filename += "queen";
                    break;
                default:
                    filename += $"{face}";
                    break;

            }
            return filename;
        }
    }
}
