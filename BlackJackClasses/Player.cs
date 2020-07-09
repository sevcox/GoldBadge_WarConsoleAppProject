using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClasses
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public bool IsGamblingAge
        //{
        //    get
        //    {
        //        if (Age < 21)
        //        {
        //            return false;
        //        }
        //        else 
        //        {
        //            return true;
        //        }
        //    }
        //}
        public Queue<Cards> Hand { get; set; }

        //Helper Method
        //Method to place into the collection of Hand
        public void Enqueue(Queue<Cards> currentCards, Queue<Cards> newCards)
        {
            foreach(var card in newCards)
            {
                currentCards.Enqueue(card);
            }
        }
    }
}
