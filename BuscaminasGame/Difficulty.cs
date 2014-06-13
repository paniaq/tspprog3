using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    class Difficulty
    {
        private int spots;
        private int mines;

        public Difficulty(int spots, int mines)
        {
            this.spots = spots;
            this.mines = (mines > spots / 3) ? spots / 3 : mines;
        }
    }
}
