﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        //member variables
        public string userName;
        public double score;
        
        

        //ctor
        public Player()
        {
            score = 0;
            
            
        }
        //member methods
        

        public void UseRock()
        {
            Console.WriteLine(userName + "used Rock!");
        }

        public void UsePaper()
        {
            Console.WriteLine(userName + "used Paper!");
        }

        public void UseScissors() 
        { 
            Console.WriteLine(userName + "used Scissors!");
        }
        public void UseLizard()
        {
            Console.WriteLine(userName + "used Lizard!");
        }
        public void UseSpock()
        {
            Console.WriteLine(userName + "used Spock!");
        }

        








    }
}
