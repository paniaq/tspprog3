using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    class Board
    {
        List<List<Spot>> spotlist;

        public Board(Difficulty difficulty)
        {
            //
        }

        public Spot GetSpotAt(int x, int y)
        {
            return this.spotlist[x][y];
        }
    }
}
