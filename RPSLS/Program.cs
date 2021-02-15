using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform battleTime = new Platform();
            Movelist gestures = new Movelist();
            User player1 = new User();
            Move rock = new Move("Rock", 0);
            Move paper = new Move("Paper", 1);
            Move scissors = new Move("Scissors", 2);
            Move lizard = new Move("Lizard", 3);
            Move spock = new Move("Spock", 4);
            gestures.gestures.Add(rock);
            gestures.gestures.Add(paper);
            gestures.gestures.Add(scissors);
            gestures.gestures.Add(lizard);
            gestures.gestures.Add(spock);
            battleTime.DisplayRules();
            player1.ChooseGesture(gestures, player1);
            
        }
    }
}
