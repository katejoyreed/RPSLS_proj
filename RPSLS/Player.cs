using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string userName;
        public double score;
        

        //ctor
        public Player(string userName)
        {
            this.userName = userName;
            score = 0;
        }
        //member methods


        
        



        //Can gain points in a round
        public abstract void WinRound();



        //Can win or lose a round
        public abstract void LoseRound();

        //Can win or lose a game
    }
}
