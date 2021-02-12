using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform battleTime = new Platform();
            battleTime.DisplayRules();
            AI computer = new AI();
            Movelist gestures = new Movelist();
            Move rock = new Move("rock", 1);
            Move paper = new Move("paper", 2);
            Move scissors = new Move("scissors", 3);
            Move lizard = new Move("lizard", 4);
            Move spock = new Move("spock", 5);
            gestures.gestures.Add(spock);
            gestures.gestures.Add(lizard);
            gestures.gestures.Add(scissors);
            gestures.gestures.Add(paper);
            gestures.gestures.Add(rock);
            User player1 = new User();
            player1.ChooseGesture(gestures);
            computer.ChooseGesture(gestures);
        }
    }
}
