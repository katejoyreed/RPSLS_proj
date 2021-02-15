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

        public Move ChooseGesture() 
        {
            var random = new Random();
            int index = random.Next(gestures.gestures.Count);
            if (index == 0) 
            {
                UseRock();
                return gestures.gestures[0];
            }
            else if (index == 1)
            {
                UsePaper();
                return gestures.gestures[1];
            }
            else if (index == 2)
            {
                UseScissors();
                return gestures.gestures[2];
            }
            else if (index == 3)
            {
                UseLizard();
                return gestures.gestures[3];
            }
            else if (index == 4)
            {
                UseSpock();
                return gestures.gestures[4];
            }
        }
    }
}
