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
        public List<string> gestures = new List<string>();
        public string chosenGesture;

        //Constructorsplayer;

        public Player()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

        }   //Member can DO the following
        public virtual void ChooseGesture()
        {
           Console.WriteLine("Select Gestures");
        }
    }
}  

