using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    //public enum Face
    //{
    //    Ace = 1,
    //    Two,
    //    Three,
    //    Four,
    //    Five,
    //    Six,
    //    Seven,
    //    Eight,
    //    Nine,
    //    Ten,
    //    Jack,
    //    Queen,
    //    King
    //}

    public enum Suit
    {
        OfHearts =1,
        OfSpades,
        OfClubs,
        OfDiamonds
    }
    public class Cards
    {
        //Properties
        //public Face Face { get; set; }
        public string CardName { get; set; }
        public Suit Suit { get; set; }
        public int Value { get; set; }

        //Methods
        public string FaceToValue(int value, Suit suit)
        {
            string face = "";
            if (value >= 2 && value <= 10)
            {
               face = value.ToString();
            }
            else if (value == 11)
            {
                face = "Jack";
            }
            else if(value == 12)
            {
                face = "Queen";
            }
            else if(value == 13)
            {
                face = "King";
            }
            else if(value == 14)
            {
                face = "Ace";
            }
            return face + Enum.GetName(typeof(Suit), suit);

        }

        //Constructors
        public Cards()
        {

        }
        //public Cards(Face face, Suit suit, int value)
        //{
        //    Face = face;
        //    Suit = suit;
        //    Value = value;
        //}
    }
}

