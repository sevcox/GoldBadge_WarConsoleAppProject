using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ProgramUI
    {
        private readonly Repo _repo = new Repo();
        public void Run()
        {
            //Intro
            string lineBreak = "----------------------------------------------------------------------------------------";
            Console.WriteLine("Hello! Welcome to the Game of War!\n" +
                "War requires two people. Grab a friend and begin.\n" +
                 lineBreak + "\n" +
                "Player One, what is your name?");
            Player playerOne = new Player();
            playerOne.Name = Console.ReadLine();
            string nameOne = playerOne.Name;
            Console.Clear();
            Console.WriteLine("Alright! Player Two, what is your name?");
            Player playerTwo = new Player();
            playerTwo.Name = Console.ReadLine();
            string nameTwo = playerTwo.Name;
            Console.Clear();
            Console.WriteLine("Well nice to meet you " + nameOne + " and " + nameTwo + " ! Are you both ready to play? Please say Y for Yes and N for No.");
            string playerStartInput = Console.ReadLine();
            _repo.ReadyToPlay(playerStartInput);

            //Game Rules
            Console.WriteLine(lineBreak + "\n" +
                "Game Rules: \n" +
                "1. I am now your only friend! Sorry " + nameTwo + ", " + nameOne + " told me this was war! War only has enemies! \n" +
                "2. Each player will be given a random card from a deck of cards. \n" +
                "3. The player with the highest card value wins and reigns as War Champion.  \n" +
                "4. The War Champion is entitled to bragging rights! \n" +
                "Easy enough? Press enter and let the war begin!");
            Console.ReadLine();
            Console.Clear();

            //Start Game
            var firstCard = _repo.StartGame();
            Console.WriteLine("Okay " + nameOne + ", time for you to draw your first card. Just reach through the screen or something. \n" +
                "Okay, I am kidding obviously! I will hand you your card. \n" +
                lineBreak + "\n" +
                "Your card is: " + firstCard); //This is where the magic happens! Breakpoint This!!!!!!!

            Console.WriteLine(lineBreak + "\n" +
                nameTwo + " it's your chance to steal the victory... Are you ready? Type your response and press enter.");
            Console.ReadLine();
            Console.Clear();
            var secondCard = _repo.StartGame();
            Console.WriteLine("Yeah, your response didn't really matter. I'm going to show you anyways! Drumroll please...\n" +
                lineBreak + "\n" +
                "Your card is: " + secondCard);
            Console.ReadLine();
            Console.Clear();

            //War Champion
            Console.WriteLine("Now you have probably already figured out the winner. But just for kicks and giggles... THE WAR CHAMPION IS... \n" +
                lineBreak);
            var faceOne = firstCard.Face;
            var faceTwo = secondCard.Face;

            if (_repo.EvaluteWinner(faceOne, faceTwo) == "True")
            {
                Console.WriteLine(nameOne + " you are the War Champion! Bragging rights until the end of times... or until " + nameTwo + " beats you!");
            }
            else if (_repo.EvaluteWinner(faceOne, faceTwo) == "False")
            {
                Console.WriteLine(nameTwo + " you are the War Champion! Bragging rights until the end of times... or until " + nameOne + " beats you!");
            }
            else if (_repo.EvaluteWinner(faceOne, faceTwo) == "Null")
            {
                Console.WriteLine("Well I guess sometimes in War there isn't always a winner! \n" +
                    lineBreak + "\n" +
                    "Who am I kidding? There is always a winner! Play again!");
            }

            //Closing Remarks
            Console.WriteLine("Winner, press enter to see your prize!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How old are you?");
            Player winner = new Player();
            int age = Convert.ToInt32(Console.ReadLine());
            winner.Age = age;
            if (winner.IsDrinkingAge == true)
            {
                Console.WriteLine("Get a beer on me! Well that's if you drink of course... if not tell the loser to bend a knee.");
            }
            else if (winner.IsDrinkingAge == false)
            {
                Console.WriteLine("Get a shirley temple on me! Well that's if you like that of course... if not tell the loser to bend a knee.");
            }
            else
            {
                Console.WriteLine("Ummm... did you put in an age?");
            }


            Console.WriteLine(lineBreak + "\n" +
                "Alright! That's all for now. See you again soon!");
        }

    }
}

