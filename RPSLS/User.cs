using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class User : Player
    {
        

        public User()   
        {
            
            
        }
        public  void ChooseGesture(Movelist gestures, Player player)
        {
            Console.WriteLine("Select your gesture:");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + gestures.gestures[i].gestureName);
            }
            int userInput = Int32.Parse(Console.ReadLine());
            
            if (userInput == gestures.gestures[0].value) 
            {
                UseRock();
            }
            else if (userInput == gestures.gestures[1].value) 
            {
                UsePaper();
            }
            else if (userInput == gestures.gestures[2].value) 
            {
                UseScissors();
            }
            else if (userInput == gestures.gestures[3].value) 
            {
                UseLizard();
            }
            else if (userInput == gestures.gestures[4].value) 
            {
                UseSpock();
            }
        }
    }
    
}
