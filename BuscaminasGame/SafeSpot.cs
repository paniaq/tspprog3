using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    [Serializable]
    public class SafeSpot : Spot
    {
        private int mines;        

        //Contructor
        public SafeSpot(int x, int y) : base(x, y)
        {
            this.mines = 0;
        }

        public int Mines
        {
            get { return mines; }
            set { mines = value; }
        }

        public override bool Cascade(Board board)
        {

            if(this.mines != 0 || this.IsDiscovered() || this.HasFlag()) 
            {
                this.Discover();
                return true;
            }

            this.Discover();            

            for (int i = this.GetX() - 1; i <= this.GetX() + 1; i++)
            {
                for (int j = this.GetY() - 1; j <= this.GetY() + 1; j++)
                {
                    if ((i >= 0) && (i < board.GetLength() && (j >= 0) && (j < board.GetLength())))
                    {

                        if (!(i == this.GetX() && j == this.GetY()))
                        {
                            if (board.GetSpotAt(i,j) is SafeSpot)
                            {
                                if (((SafeSpot)board.GetSpotAt(i, j)).Mines == 0)
                                {
                                    board.GetSpotAt(i, j).Cascade(board);
                                }
                                else
                                {
                                    board.GetSpotAt(i, j).Discover();
                                }

                            }
                        }
                    }
                }
            }

            return true;

        }
        
    }
}
