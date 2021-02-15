using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Movelist
    {//member variable
        public List<Move> gestures;

        public Movelist()
        {
            gestures = new List<Move>();
            Move rock = new Move("Rock");
            Move paper = new Move("Paper");
            Move scissors = new Move("Scissors");
            Move lizard = new Move("Lizard");
            Move spock = new Move("Spock");
            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }


        //member methods

       

        
      

    }



}
