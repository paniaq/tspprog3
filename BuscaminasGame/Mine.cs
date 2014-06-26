using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public class Mine : Spot
    {

        public Mine(int x, int y) : base(x, y) 
        {

        }

        public bool Cascade() 
        {
            return false;
        }

        override public string ToString() 
        {
            return "M";
        }

    }
}
