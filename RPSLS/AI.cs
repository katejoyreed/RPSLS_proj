using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AI : Player   
    { 

        public AI()
        {
            userName = "Computer";
            score = 0;
        }

        public void ChooseGesture(Movelist gestures) 
        {
            var random = new Random();
            int index = random.Next(gestures.gestures.Count);
            if (index == gestures.gestures[0].value) 
            {
                UseRock();
            }
            else if (index == gestures.gestures[1].value)
            {
                UsePaper();
            }
            else if (index == gestures.gestures[2].value)
            {
                UseScissors();
            }
            else if (index == gestures.gestures[3].value)
            {
                UseLizard();
            }
            else if (index == gestures.gestures[4].value)
            {
                UseSpock();
            }
        }
    }
}
