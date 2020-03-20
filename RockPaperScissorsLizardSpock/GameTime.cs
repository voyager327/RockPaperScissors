﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameTime
    {

        // member variables (HAS A)
        Player Player1;
        Player Player2;
        string Gesture;
        List<string> gestures = new List<string>();

        // constructor 
        public GameTime()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

        }

        public void RunGame()
        {
            DisplayRules();
            GameMode();
            ChosenGesture();

        }

        public void GameMode() 
        {
            Console.WriteLine("Pick Game Mode. 1 for vs AI, 2 for Vs Human");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string userName;
                Console.WriteLine("What is your name?");
                userName = Console.ReadLine();
                Player1 = new Human(userName);
                Player2 = new AI(userInput);
            }
            else
            {
                string userName;
                userName = Console.ReadLine();
                Player1 = new Human(userName);
                Player2 = new Human(userName);
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Human Player Will Select Gesture while AI Player Will Run Random to Select Gesture");
            Console.WriteLine("Rock Beat Scissors and Lizard");
            Console.WriteLine("Paper Beat Rock and Spock");
            Console.WriteLine("Scissor Beat Paper and Lizard");
            Console.WriteLine("Lizard Beat Paper and Spock");
            Console.WriteLine("Spock Beat Scissor and Rock");
            Console.ReadLine();
        }

        //public void ChooseGesture() //Player Choose Gesture to Win the Game 
        //{
        //    Console.WriteLine("Choose Gesture to Play Game\n");
        //    string Gesture = Console.ReadLine();

        //    switch (Gesture)
        //    {
        //        case "RocK":
        //            Console.WriteLine("Rock Beats Scissors && Lizard");
        //            break;
        //        case "Paper":
        //            Console.WriteLine("Paper Beats Rock && Spock");
        //            break;
        //        case "Scissors":
        //            Console.WriteLine("Scissors Beats Paper && Lizard");
        //            break;
        //        case "Lizard":
        //            Console.WriteLine("Lizard Beats Paper && Spock");
        //            break;
        //        case "Spock":
        //            Console.WriteLine("Spock Beats Scissors and Rock");
        //            break;
        //        default:
        //            Console.WriteLine("Tie");
        //            break;
        //    }
        //}
        public void ChosenGesture() // Chosen Determines winner
        {
            if (Player1.ChosenGesture == "Rock" && Player2.ChosenGesture == "Scissors" || Player2.ChosenGesture == "Lizard")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins the Round");
                Console.WriteLine("Player1 score is" + Player1.score);
                Console.ReadLine();
            }
            else if (Player1.ChosenGesture == "Paper" && Player2.ChosenGesture == "Rock" || Player2.ChosenGesture == "Spock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins the Round");
                Console.WriteLine("Player1 score is" + Player1.score);
                Console.ReadLine();
            }
            else if (Player1.ChosenGesture == "Scissors" && Player2.ChosenGesture == "Paper" || Player2.ChosenGesture == "Lizard")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins the Round");
                Console.WriteLine("Player1 score is" + Player1.score);
                Console.ReadLine();
            }
            else if (Player1.ChosenGesture == "Lizard" && Player2.ChosenGesture == "Paper" || Player2.ChosenGesture == "Spock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins the Round");
                Console.WriteLine("Player1 score is" + Player1.score);
                Console.ReadLine();
            }
            else if (Player1.ChosenGesture == "Spock" && Player2.ChosenGesture == "Scissors" || Player2.ChosenGesture == "Rock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins the Round");
                Console.WriteLine("Player1 score is" + Player1.score);
                Console.ReadLine();
            }

        }
        public void CompareGesture(int Player1, int Player2)
        {
                            
        }
    }
}



//public void RunGame()
//{
//    while(Player1Score < 3 && Player2Score < 3)
//        int Player1 = 
//}


















//public GameTime(List<string> gestures)
//{
//    gestures = new List<string>();

//    gestures Gesture1 = new gestures("Rock");
//    gestures Gesture2 = new Gestures("Paper");
//    Gestures Gesture3 = new Gestures("Scissors");
//    Gestures Gestures4 = new Gestures("Lizard");
//    Gestures Gestures5 = new Gestures("Spock");

//    robots.Add(robot1);
//    robots.Add(robot2);
//    robots.Add(robot3);


// member methods (CAN DO)

// this method NEEDS a Rules of the Game

