using System;
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
        public List<string> gestures;
        //string Gesture;
        public List<string> chosenGesture = new List<string>();
        
        // constructor 
        public GameTime()
        {
            chosenGesture.Add("Rock");
            chosenGesture.Add("Paper");
            chosenGesture.Add("Scissors");
            chosenGesture.Add("Lizard");
            chosenGesture.Add("Spock");

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
                Player1 = new Human("Player");
                Player2 = new AI("Player");
            }
            else
            {
                string userName;
                userName = Console.ReadLine();
                Player1 = new Human("Player");
                Player2 = new Human("Player");
                Console.ReadLine();
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
            
        }
 
        public void ChosenGesture() // This Method don't run
        {
            if (Player1.ChosenGesture == "Rock" && Player2.ChosenGesture == "Scissors" || Player2.ChosenGesture == "Lizard")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Player1 score is" + Player1.score);

            }
            else if (Player1.ChosenGesture == "Paper" && Player2.ChosenGesture == "Rock" || Player2.ChosenGesture == "Spock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Player1 score is" + Player1.score);

            }
            else if (Player1.ChosenGesture == "Scissors" && Player2.ChosenGesture == "Paper" || Player2.ChosenGesture == "Lizard")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Player1 score is" + Player1.score);

            }
            else if (Player1.ChosenGesture == "Lizard" && Player2.ChosenGesture == "Paper" || Player2.ChosenGesture == "Spock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Player1 score is" + Player1.score);

            }
            else if (Player1.ChosenGesture == "Spock" && Player2.ChosenGesture == "Scissors" || Player2.ChosenGesture == "Rock")
            {
                Player1.score++;
                Console.WriteLine("Player1 Wins");
                Console.WriteLine("Player1 score is" + Player1.score);
                
            }
            else
            {
                Console.WriteLine("Tie");
                Console.ReadLine();
            }
           
            }
        public void DisplayScore(int Player1, int Player2)
        {




        }
        public void RunGame()
        {
            DisplayRules();
            GameMode();
            ChosenGesture();
            
        }
    }       
}

//}
////public void ChooseGesture() //Player Choose Gesture to Win the Game 
//{
//    Console.WriteLine("Choose Gesture to Play Game.\n1) Rock\n2 Paper\n3) Scissors\n4) Lizard\n5) Spock");
//    int choice = Convert.ToInt32(Console.ReadLine()); // Having issues with this 
//    switch (choice)
//    {
//        case 1:
//            break;
//        case 2:
//            break;
//        case 3:
//            break;
//        case 4:
//            break;
//        case 5:
//            break;

//            //public Dinosaur[] dinosaurs;

//            // inosaurs = new Dinosaur[3];

//            //Dinosaur dinosaur1 = new Dinosaur("T-Rex");
//            //Dinosaur dinosaur2 = new Dinosaur("Raptor");
//            //Dinosaur dinosaur3 = new Dinosaur("Triceratops");

//            //dinosaurs[0] = dinosaur1;
//            //dinosaurs[1] = dinosaur2;
//            //dinosaurs[2] = dinosaur3;
//    }
//    return;

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

