﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Platform
    {
        //start a game
        User playerOne = new User();
        User player1 = new User();
        Movelist gestures = new Movelist();
        
        

        //display rules
        public void DisplayRules() 
        {
            Console.WriteLine("Would you like to see the rules?");
            string userInput = Console.ReadLine();
            if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock is a variant of the classic Rock, Paper, Scissors game.");
                Console.WriteLine();
                Console.WriteLine("In this variant, players may choose two additional gestures - Lizard and Spock");
                Console.WriteLine();
                Console.WriteLine("The gameplay is as follows:");
                Console.WriteLine();
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine();
                Console.WriteLine("You will choose to play against a human or computer opponent and how many rounds you will play.");
                Console.WriteLine();
                Console.WriteLine("To win the game, you must win a majority of the rounds by choosing a gesture that bests the other player.");

            }
            else if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock is a variant of the classic Rock, Paper, Scissors game.");
                Console.WriteLine();
                Console.WriteLine("In this variant, players may choose two additional gestures - Lizard and Spock");
                Console.WriteLine();
                Console.WriteLine("The gameplay is as follows:");
                Console.WriteLine();
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine();
                Console.WriteLine("You will choose to play against a human or computer opponent and how many rounds you will play.");
                Console.WriteLine();
                Console.WriteLine("To win the game, you must win a majority of the rounds by choosing a gesture that bests the other player.");
                Console.WriteLine();
            }
        }

        //choose number of players
        public void ChoosePlayers()
        {
            Console.WriteLine("How would you like to play?");
            Console.WriteLine("Press 0 to play against the computer");
            Console.WriteLine("Press 1 to play against another person");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 0)
            {
                AI playerTwo = new AI();
            }
            else if (userInput == 1)
            {
                User playerTwo = new User();
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                ChoosePlayers();
            }
        }
        //choose number of rounds (best two of three or more)
        public int ChooseRounds()
        {
            Console.WriteLine("How many rounds would you like to play?");
            
        }
        //fight
        public void Fight() 
        {
            

        }

        public void CompareGestures(User playerOne, Player playerTwo)
        {
            if (playerOne.ChooseGesture() == gestures.gestures[0])
            {
                if (playerTwo.ChooseGesture() == gestures.gestures[1] || playerTwo.ChooseGesture () == gestures.gestures[4])
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
            
            //rock > scissors
            //scissors > paper
            //paper > rock
            //rock > lizard
            //lizard > paper
            //paper > spock
            //spock > paper
        }
        
    }
}
