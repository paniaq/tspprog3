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
            this.name = n;
            this.score = 0;
        }

        public string GetName()
        {
            return this.name;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
