using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    class SafeSpot : Spot
    {
        private int mines;        

        public SafeSpot()
        {
            this.mines = 0;
        }

        public int Mines
        {
            get { return mines; }
            set { mines = value; }
        }

        new public bool Cascade()
        {
            //todo
            return true;
        }
    }
}
