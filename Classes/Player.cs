using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Player
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsDrinkingAge
        {
            get
            {
                if (Age >= 21)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
