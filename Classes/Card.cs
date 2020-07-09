using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Card
    {

        public string Face;
        public string Suit;

        public Card(string cardFace, string cardSuit)
        {
            Face = cardFace;
            Suit = cardSuit;
        }
        public override string ToString()
        {
            return Face + " of " + Suit;
        }
    }
}
