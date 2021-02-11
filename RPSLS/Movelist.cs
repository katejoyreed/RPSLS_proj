using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Movelist
    {//member variable
        public List<Move> moveList;

        public Movelist()
        {
            moveList = new List<Move>();
        }


        //member methods

        //create move

        public Move CreateMove(string gestureName, double value) 
        {
           Move move = new Move(gestureName, value);
            return move;
        }
        //populate movelist
        public void PopulateMovelist(Move move) 
        {
            moveList.Add(move);
        }


    }



}
