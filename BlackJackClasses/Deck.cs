using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class Deck : Cards
    {
        //Methods
        public Queue<Cards> GenerateDeck()
        {
            Queue<Cards> cards = new Queue<Cards>();
            for (int value = 2; value <= 14; value++)
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Cards()
                    {
                        Suit = (Suit)suit, //look into this more!
                        Value = value,
                        CardName = FaceToValue(value, (Suit)suit) //Method we haven't created to equal our face name to value

                    });
                }
            }
            return Shuffle(cards);

        }
        public void Shuffle()
        {

            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }

        }
            //Constructors
            public Deck()
        {
            GenerateDeck();
        }

    }
}
