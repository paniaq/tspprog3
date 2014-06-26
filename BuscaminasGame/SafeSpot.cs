using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public class SafeSpot : Spot, ICascadable
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

        public bool Cascade(Board board)
        {

            if(this.mines != 0 || this.IsDiscovered() || this.HasFlag()) 
            {
                return true;
            }

            this.Discover();

            int x = -1;
            int y = -1;

            int c1 = 3;
            int c2 = 3;

            while (c1 != 0)
            {

                while (c2 != 0)
                {

                    //Estoy dentro del tablero?

                    if (this.GetX() + x < 0 && this.GetX() + x >= board.GetLength())
                    {
                        if (this.GetY() + y < 0 && this.GetY() + y >= board.GetLength())
                        {

                            //Soy yo mismo?

                            if (x != 0 && y != 0)
                            {

                                board.GetSpotAt(this.GetX() + x, this.GetY() + y).Cascade(board);

                            }

                        }

                    }

                    c2--;
                    y++;

                }

                x++;
                c1--;

                c2 = 3;
                y = -1;

            }

            return true;

        }

        override public string ToString()
        {
            return this.mines.ToString();
        }
    }
}
