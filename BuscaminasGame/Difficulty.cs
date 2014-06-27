using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    [Serializable]
    public class Difficulty
    {
        private int spots;        
        private int mines;

        public Difficulty(int spots, int mines)
        {
            this.spots = spots;
            this.mines = (mines > spots*spots / 5) ? (spots*spots / 5) : mines;
        }

        public int GetSpots() {

            return this.spots;

        }

        public int GetMines() {

            return this.mines;

        }
    }
}
