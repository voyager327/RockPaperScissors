﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{

    public class AI : Player
    {
        //public string playerName;
        //public int score;
        //List<string> gestures = new List<string>();
        //public string chosenGesture;

        public AI(string Machina)
        {

            this.score = 0;
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("AI Randomly Choose Gesture");
            {
                var random = new Random();
                {
                    var list = new List<string> { "Rock, Paper, Scissors, Lizard, Spock" };
                    int index = random.Next(list.Count);
                    Console.WriteLine("AI Choose: " + list[index]);
                }

                //public override void ChooseGesture()
                //{
                //    Console.WriteLine("AI Randomly Choose Gesture");
                //    Random rnd = new Random();
                //    {
                //var list = new List<string>("Rock,", "Paper", "Scissors", "Lizard", "Spock");
                //int index = random.Next(list.Count);
                //        Console.WriteLine("AI Choose: " + list[index]);
                //        Console.ReadLine();


            }


        }
    }
}






        //    //AI Choses Gestures Randomly
        //    Console.WriteLine("AI Choses Gestures Randomly");
        //    chosenGesture = "";
            
        //    Random rnd = new Random();
        //    public int sides;
        //}
        //   int gestures = rnd.Next(0, 4);
        //   return
      
     
    

