using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    [Serializable]
    public class Mine : Spot
    {

        public Mine(int x, int y) : base(x, y) 
        {

        }

        public override bool Cascade(Board board) 
        {
            this.Discover();
            return false;
        }        

    }
}
