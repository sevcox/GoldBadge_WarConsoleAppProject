using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
            
    public class Deck
    {
        //Fields which are essentially properties just more private for the developer
        private readonly Repo _repo = new Repo();
        //private readonly string[] _faces = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        
        private readonly string[] _suits = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };
        private readonly Card[] _deck = new Card[52];
        private readonly Random _randomcard = new Random();

        //Properties
        public int currentHand;
        //Methods
        public void Shuffle()
        {
            currentHand = 0;
            for (int firstCard = 0; firstCard < _deck.Length; firstCard++)
            {
                int secondCard = _randomcard.Next(52);
                Card fillerCard = _deck[firstCard]; //saving the card here
                _deck[firstCard] = _deck[secondCard];
                _deck[secondCard] = fillerCard; //swapped it out with the second
            }
        }
        public Card DealCard()
        {
            if (currentHand < _deck.Length)
            {
                return _deck[currentHand++];
            }
            return null;
        }


        //Constructor ---- this one is particular just fires off everything we call the deck class so that it will give us a random deck (so we don't have to call a method every time we call the class
        public Deck()
        {
            var deck = new Card[52];
            var randomCard = new Random();
            currentHand = 0;
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(_repo._faces[count % 11], _suits[count / 13]);
            }

            _deck = deck;
            //var value = _repo.EvaluateCard(_deck[2].Face);
            _randomcard = randomCard;
        }
    }
}
