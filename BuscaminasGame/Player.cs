using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public class Player : IPlayer
    {

        private string name;
        private int score;

        //Constructor
        public Player(string n)
        {
            this.name = n.Replace("@", " ");
            this.score = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value.Replace("@", " "); }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int CompareTo(IPlayer other)
        {
            if(this.Score > other.Score) 
            {
                return 1;
            }
            else if (this.Score < other.Score)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
