using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Repo
    {
        public Dictionary<string, int> _faceAndValue = new Dictionary<string, int>();
        public List<string> _faces = new List<string>();

        //do a constructor that calls SeedDictionary
        public Repo()
        {
            SeedDictionary();

        }



        public void ReadyToPlay(string playerInput)
        {
            string newPlayerInput = playerInput.ToLower();
            if (newPlayerInput == "y")
            {
                Console.WriteLine("Alright! Let's do this!");
            }
            else if (newPlayerInput == "n")
            {
                Console.WriteLine("Well alright! I understand! You are tired of getting beat! See you later!");
            }
            else
            {
                Console.WriteLine("Well we can't even play the game if you can't follow simple instructions!");
            }
        }
        public Card StartGame()
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle();
            Card firstCard = newDeck.DealCard();
            return firstCard;
        }

        public void SeedDictionary()
        {
            _faceAndValue.Add("Ace", 1);
            _faceAndValue.Add("Two", 2);
            _faceAndValue.Add("Three", 3);
            _faceAndValue.Add("Four", 4);
            _faceAndValue.Add("Five", 5);
            _faceAndValue.Add("Six", 6);
            _faceAndValue.Add("Seven", 7);
            _faceAndValue.Add("Eight", 8);
            _faceAndValue.Add("Nine", 9);
            _faceAndValue.Add("Ten", 10);
            _faceAndValue.Add("Jack", 11);
            _faceAndValue.Add("Queen", 12);
            _faceAndValue.Add("King", 13);

            foreach (KeyValuePair<string, int> keyValuePair in _faceAndValue)
            {
                _faces.Add(keyValuePair.Key); 
            }
        }
        public string EvaluteWinner(string faceOne,  string faceTwo)
        {

            var valueOne = EvaluateCard(faceOne);
            var valueTwo = EvaluateCard(faceTwo);
            if (valueOne > valueTwo)
            {
                return "True";
            }
            else if (valueOne < valueTwo)
            {
                return "False";
            }
            return "Null";
        }

        //Method called EvaluateCard takes in a string, returns an int
        //the string will be the face, and is the key in our Dictionary to get the value for that face
        public int EvaluateCard(string face)
        {
            bool gotValue = _faceAndValue.TryGetValue(face, out int value);
            // you could use the bool to put in validation to catch a face that doesn't exist for some reason
            // if !gotValue {return an error some how, or return 0 and that have further validation in the UI that if this method returns 0 display an error, and have them try again

            return value;
        }
    }

}
