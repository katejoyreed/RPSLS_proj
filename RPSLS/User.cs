using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class User : Player
    {
        

        public User(string userName, double score)   
        {
            
            
        }
        public  int ChooseGesture(Movelist movelist)
        {
            Console.WriteLine("Select your gesture:");
            for (int i = 0; i < movelist.moveList.Count; i++)
            {
                Console.WriteLine("Press " + i + " for " + movelist.moveList[i]);
            }
            int userInput = Int32.Parse(Console.ReadLine());
            return userInput;
        }
    }
    
}
