﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    [Serializable]
    public abstract class Spot : ICascadable
    {
        private bool discovered;
        private bool flag;
        private int x;
        private int y;
        
        //Constructor
        public Spot(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.discovered = false;
            this.flag = false;
        }

        public int GetX() 
        {
            return this.x;
        }

        public int GetY() 
        {
            return this.y;
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

        public void ToggleFlag()
        {
            if (!discovered)
            {
                flag = !flag;
            }
        }

        abstract public bool Cascade(Board board);
        
    }
}
