using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //Member Variables (HAS 
        public string playerName;
        public int score;
        public List<string> gestures;
        public string ChosenGesture;
        //public List<string> ChosenGesture;

        //Constructorsplayer;

        public Player()
        {
            //gestures = new List<string>();
            //gestures.Add("Rock");
            //gestures.Add("Paper");
            //gestures.Add("Scissors");
            //gestures.Add("Lizard");
            //gestures.Add("Spock");

            //chosenGesture = new List<string>();
            //chosenGesture.Add("Rock");
            //chosenGesture.Add("Paper");
            //chosenGesture.Add("Scissors");
            //chosenGesture.Add("Lizard");
            //chosenGesture.Add("Spock");
                 

        }   //Member can DO the following
        public virtual void ChooseGesture()
        {
           Console.WriteLine("Select Gestures");
        }
    }
}  

