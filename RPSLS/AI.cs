using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AI : Player   
    { 

        public AI()
        {

        }

        public int ChooseGesture(Movelist gestures) 
        {
            var random = new Random();
            int index = random.Next(gestures.gestures.Count);
            return index;
        }
    }
}
