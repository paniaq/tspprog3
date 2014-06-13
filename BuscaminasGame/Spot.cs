using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public abstract class Spot : ICascadable
    {
        private bool discovered;
        private bool flag;
        
        //Constructor
        public Spot()
        {
            this.discovered = false;
            this.flag = false;
        }

        public bool IsDiscovered() 
        {
            return this.discovered;
        }

        public bool HasFlag()
        {
            return this.flag;
        }

        public void Discover()
        {
            if (!flag)
            {
                discovered = true;
            }
        }

        public void PutFlag()
        {
            if (!discovered)
            {
                flag = true;
            }
        }

        public bool Cascade()
        {
            return true;
        }
    }
}
