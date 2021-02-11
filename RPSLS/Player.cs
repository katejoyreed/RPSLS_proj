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
        public abstract Move ChooseGesture(Movelist movelist)
        {
            
        }
        

        //Can gain points in a round
        public abstract void WinRound() 
        { 
            
        }


        //Can win or lose a round

        //Can win or lose a game
    }
}
