using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public double score;

        //ctor
        public Player()
        {
            score = 0;
        }
        //member methods

        
        //Can choose RPSLS from a movelist
        public int ChooseGesture(Movelist movelist)
        {
            Console.WriteLine("Choose your gesture");
            for (int i = 0; i < movelist.moveList.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + movelist.moveList[i].gestureName); 
            }
            int userInput = Int32.Parse(Console.ReadLine());
            return userInput;
        }
        

        //Can gain points in a round
        public void WinRound() 
        { 
            
        }


        //Can win or lose a round

        //Can win or lose a game
    }
}
