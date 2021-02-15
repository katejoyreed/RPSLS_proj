using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class User : Player
    {
        

        public User()   
        {
            score = 0;
            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();
        }
        public override Move ChooseGesture()
        {
            Console.WriteLine("Select your gesture:");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + gestures.gestures[i].gestureName);
            }
            int userInput = Int32.Parse(Console.ReadLine());
            
            if (userInput == 0) 
            {
                UseRock();
                return gestures.gestures[0];
            }
            else if (userInput == 1) 
            {
                UsePaper();
                return gestures.gestures[1];
            }
            else if (userInput == 2) 
            {
                UseScissors();
                return gestures.gestures[2];
            }
            else if (userInput == 3) 
            {
                UseLizard();
                return gestures.gestures[3];
            }
            else if (userInput == 4) 
            {
                UseSpock();
                return gestures.gestures[4];
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                return ChooseGesture();
            }
        }
    }
    
}
