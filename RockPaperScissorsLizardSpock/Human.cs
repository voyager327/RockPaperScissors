﻿using System;
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

        
        
        

            ChooseGesture();
          //public override void ChooseGesture() //Player Choose Gesture to Win the Game 
          //{
          //    string ChooseGesture;
          //    Console.WriteLine("Choose Gesture to Play. 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, 5 for Spock");
          //    string userInput = Console.ReadLine();
          //    if (userInput == "1")
          //    {
           //        ChosenGesture = ""

            //        //string chosenGestures;
            //        //Console.WriteLine("Choose your Gesture");
            //        //chosenGesture = Console.ReadLine();
            //        //chosenGesture = new ChooseGesture

            //    }

            //    string gestures;
            //    Console.WriteLine("Choose Gesture to Play Game\n");
            //    string Gesture = Console.ReadLine();
            //    chosenGesture = new ("");

            //    chosenGesture = new chosenGesture[4];
            //    chosenGesture chosenGesture1 = new chosenGesture("Rock");
            //    chosenGesture chosenGesture2 = new chosenGesture("Paper");
            //    chosenGesture chosenGesture3 = new chosenGesture("Scissors");
            //    chosenGesture chosenGesture4 = new chosenGesture("Lizard");
            //    chosenGesture chosenGesture5 = new chosenGesture("Spock");

            //    chosenGesture[0] = chosenGesture1;
            //    chosenGesture[1] = chosenGesture1;
            //    chosenGesture[2] = chosenGesture2;
            //    chosenGesture[3] = chosenGesture3;
            //    chosenGesture[4] = chosenGesture4;
        }
        public override void ChooseGesture() //Player Choose Gesture to Win the Game 
        {
            //string[] ChooseGestureArray = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            //ChooseGestureArray[0] = "Rock";
            //ChooseGestureArray[1] = "Paper";
            //ChooseGestureArray[2] = "Scissors";
            //ChooseGestureArray[3] = "Lizard";
            //ChooseGestureArray[4] = "Spock";
            //Console.WriteLine("Pick Gesture to Play");
            //Console.ReadLine();

            //string[] ChooseGesture = new string[4] {"Rock", "Paper", "Scissors", "Lizard", "Spock"};

            Console.WriteLine("Choose Gesture to Play Game.\n1) Rock\n2 Paper\n3) Scissors\n4) Lizard\n5) Spock");
            int choice = Convert.ToInt32(Console.ReadLine()); // Having issues with this 
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;

                    //public Dinosaur[] dinosaurs;
                    
                    // inosaurs = new Dinosaur[3];

                    //Dinosaur dinosaur1 = new Dinosaur("T-Rex");
                    //Dinosaur dinosaur2 = new Dinosaur("Raptor");
                    //Dinosaur dinosaur3 = new Dinosaur("Triceratops");

                    //dinosaurs[0] = dinosaur1;
                    //dinosaurs[1] = dinosaur2;
                    //dinosaurs[2] = dinosaur3;
            }
            return;
        }
 
    } 
}     
       //public override void ChooseGesture()
        //{
            //Console.WriteLine("Player Pick Gesture");



            //chosenGesture = "rock";
        
    


            //List<string> gestures)
        
            //foreach(string name)
            //{
            //Console.WriteLine(gestures);
            //ChooseGesture Rock = new ChooseGesture("Rock");
            //ChooseGesture Paper = new ChooseGesture("Paper");
            //ChooseGesture Scissors = new ChooseGesture("Scissors");
            //ChooseGesture Lizard = new ChooseGesture("Lizard");
            //ChooseGesture Spock = new ChooseGesture("Spock");
            
            //Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");            
            //for (int i = 0; i < gestures.Count; i++) // round
            //{
            //    SelectGestures gesture = gesture
            //}  

            //chosenGesture = "rock";


    