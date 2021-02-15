using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Platform
    {
        //start a game
        User playerOne = new User();
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
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Spock smashes Scissors");
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
        public Player ChoosePlayers()
        {
            Console.WriteLine("How would you like to play?");
            Console.WriteLine("Press 0 to play against the computer");
            Console.WriteLine("Press 1 to play against another person");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 0)
            {
                Player playerTwo = new AI();
                return playerTwo;
            }
            else if (userInput == 1)
            {
                Player playerTwo = new User();
                return playerTwo;
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                return ChoosePlayers();
            }
        }
        //choose number of rounds (best two of three or more)
        public int ChooseRounds()
        {
            Console.WriteLine("How many rounds would you like to play?");
            Console.WriteLine("Type 0 for best of 3");
            Console.WriteLine("Type 1 for best of 5");
            Console.WriteLine("Type 2 for best of 7");
            int numberOfRounds = Int32.Parse(Console.ReadLine());
            if (numberOfRounds == 0) 
            {
                return 3;
            }
            else if (numberOfRounds == 1)
            {
                return 5;
            }
            else if (numberOfRounds == 2)
            {
                return 7;
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                return ChooseRounds();
            }
        }
        

        public void CompareGestures(User playerOne, Player playerTwo)
        {
            if (playerOne.ChooseGesture() == gestures.gestures[0])
            {
                if (playerTwo.ChooseGesture() == gestures.gestures[1] || playerTwo.ChooseGesture () == gestures.gestures[4])
                {
                    Console.WriteLine($"{playerTwo.userName} wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.ChooseGesture() == gestures.gestures[2] || playerTwo.ChooseGesture() == gestures.gestures[3]) 
                {
                    Console.WriteLine($"{playerOne.userName} wins this round!");
                    playerOne.score++;
                }
            }
            else if (playerOne.ChooseGesture() == gestures.gestures[1]) 
            {
                if (playerTwo.ChooseGesture() == gestures.gestures[2] || playerTwo.ChooseGesture() == gestures.gestures[3])
                {
                    Console.WriteLine($"{playerTwo.userName} wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.ChooseGesture() == gestures.gestures[0] || playerTwo.ChooseGesture() == gestures.gestures[4])
                {
                    Console.WriteLine($"{playerOne.userName}Player One wins this round!");
                    playerOne.score++;
                }
            }
            else if (playerOne.ChooseGesture() == gestures.gestures[2]) 
            { 
                if (playerTwo.ChooseGesture() == gestures.gestures[0] || playerTwo.ChooseGesture() == gestures.gestures[4])
                {
                    Console.WriteLine($"{playerTwo.userName} wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.ChooseGesture() == gestures.gestures[1] || playerTwo.ChooseGesture() == gestures.gestures[3])
                {
                    Console.WriteLine($"{playerOne.userName} wins this round!");
                    playerOne.score++;
                }
            }
            else if (playerOne.ChooseGesture() == gestures.gestures[3]) 
            { 
                if (playerTwo.ChooseGesture() == gestures.gestures[0] || playerTwo.ChooseGesture() == gestures.gestures[2])
                {
                    Console.WriteLine($"{playerTwo.userName} wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.ChooseGesture() == gestures.gestures[1] || playerTwo.ChooseGesture() == gestures.gestures[4]) 
                {
                    Console.WriteLine($"{playerOne.userName} wins this round!");
                    playerOne.score++;
                }

            }
            else if (playerOne.ChooseGesture() == gestures.gestures[4]) 
            {
                if (playerTwo.ChooseGesture() == gestures.gestures[1] || playerTwo.ChooseGesture() == gestures.gestures[3])
                {
                    Console.WriteLine($"{playerTwo} wins this round!");
                    playerTwo.score++;
                }
                else if (playerTwo.ChooseGesture() == gestures.gestures[0] || playerTwo.ChooseGesture() == gestures.gestures[2])
                {
                    Console.WriteLine($"{playerOne.userName} wins this round!");
                    playerOne.score++;
                }
            }
            else if (playerOne.ChooseGesture() == playerTwo.ChooseGesture()) 
            {
                Console.WriteLine("It's a draw!");
            }
            
        }
        public void Fight(Player playerTwo)
        {
            for (int i = 0; i < ChooseRounds() + 1; i++)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures(playerOne, playerTwo);
            }

        }
        public void RunPlatform() 
        {
            DisplayRules();
            Fight(ChoosePlayers());
        }

    }
}
