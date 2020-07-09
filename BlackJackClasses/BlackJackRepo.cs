using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class BlackJackRepo
    {
      
        public void HitOrStay()
        {
            if (hitOrStay.Equals("H"))
            {
                Hit();
            }
            else if (hitOrStay.Equals("S"))
            {
                if(playerTotal > dealerTotal && playerTotal <= 21)
                {
                    Console.WriteLine("----------------------------------- \n");
                    Console.WriteLine("Congrats!! You won the Game!");
                }
                else if(playerTotal < dealerTotal && dealerTotal <=21)
                {
                    Console.WriteLine("Awww man! It looks like you lost the game! The dealer had: " + dealerTotal + "! Better luck next time!");
                }
            }
        }
        public void NewDeck()
        {
            var deckOfCards = new List<Cards>();


        }

    }
}
