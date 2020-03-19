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
        public void ChooseGesture() //Player Choose Gesture to Win the Game 
        {
            string gestures;
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            base.gestures = new Gesture(userName);
            Player2 = new AI(userInput);

            Console.WriteLine("Choose Gesture to Play Game\n");
            string Gesture = Console.ReadLine();
            chosenGesture = new chosenGesture("");

            switch (Gesture)
            {
                case "RocK":
                    Console.WriteLine("Rock Beats Scissors && Lizard");
                    break;
                case "Paper":
                    Console.WriteLine("Paper Beats Rock && Spock");
                    break;
                case "Scissors":
                    Console.WriteLine("Scissors Beats Paper && Lizard");
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard Beats Paper && Spock");
                    break;
                case "Spock":
                    Console.WriteLine("Spock Beats Scissors and Rock");
                    break;
                default:
                    Console.WriteLine("Tie");
                    break;
            }
        }


    public override void ChooseGesture()
        {
            Console.WriteLine("Player Pick Gesture");



            chosenGesture = "rock";
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

