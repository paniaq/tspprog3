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

        public override bool Cascade(IBoard board) 
        {
            return false;
        }

        override public string ToString() 
        {
            return "M";
        }

    }
}
