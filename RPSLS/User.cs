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
        public  int ChooseGesture(Movelist gestures)
        {
            Console.WriteLine("Select your gesture:");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + gestures.gestures[i].gestureName);
            }
            int userInput = Int32.Parse(Console.ReadLine());
            return userInput;
        }
    }
    
}
