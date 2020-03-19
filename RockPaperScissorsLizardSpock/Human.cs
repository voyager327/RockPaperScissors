using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //public string playerName;
        //public int score;
        //public string chosenGesture;

        public Human(string player)
        {
            this.playerName = player;
            this.score = 0;
            
        }
        public void ChooseGesture()
        {
            Console.WriteLine("Player Pick Gesture");
        }
    }
}

            //List<string> gestures)
        
            //foreach(string name)
            //{
            //    Console.WriteLine(gestures);
            //    Gesture Rock = new gesture("Rock");
            //    gesture Paper = new Gesture("Paper");
            //Gesture Scissors = new Gesture("Scissors");
            //Gesture Lizard = new Gesture("Lizard");
            //Gesture Spock = new Gesture("Spock");
            
            //Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");            
            //for (int i = 0; i < gestures.Count; i++) // round
            //{
            //    SelectGestures gesture = gesture
            //}  

            //chosenGesture = "rock";

