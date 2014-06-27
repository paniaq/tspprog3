using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    [Serializable]
    public class Board
    {
        private Spot[,] spotlist;
        private Difficulty difficulty;

        public Board(Difficulty difficulty)
        {

            this.difficulty = difficulty;

            int spots = difficulty.GetSpots();

            this.spotlist = new Spot[spots,spots];            

        }

        public Spot[,] SpotList 
        {
            get { return this.spotlist; }
            set { this.spotlist = value;}
        }

        public void InitBoard() {

            for (int i = 0; i < this.spotlist.GetLength(0); i++) {

                for (int j = 0; j < this.spotlist.GetLength(0); j++)
                {

                    this.spotlist[i, j] = new SafeSpot(i,j);

                }

            }

            for(int i = 0; i < this.difficulty.GetMines(); i++) {

                Random rand = new Random();

                int x = rand.Next(0, this.spotlist.GetLength(0) - 1);
                int y = rand.Next(0, this.spotlist.GetLength(0) - 1);

                while(this.spotlist[x,y] is Mine) {

                    x = rand.Next(0, this.spotlist.GetLength(0) - 1);
                    y = rand.Next(0, this.spotlist.GetLength(0) - 1);

                }

                this.spotlist[x, y] = new Mine(x,y);

                //Esteblece adyancencia

                int m = -1;
                int n = -1;

                int c1 = 3;
                int c2 = 3;

                while (c1 != 0)
                {

                    while (c2 != 0)
                    {

                        //Estoy dentro del tablero?

                        if (x + m >= 0 && x + m <= this.spotlist.GetLength(0))
                        {
                            if (y + n >= 0 && y + n <= this.spotlist.GetLength(0))
                            {                                

                                //Soy yo mismo?
                                if ( n != 0 || m != 0 )
                                {

                                    //Es un SafeSpot?
                                    if(this.spotlist[x+m, y+n] is SafeSpot) 
                                    {

                                        ((SafeSpot)this.spotlist[x + m, y + n]).Mines++;

                                    }

                                }

                            }

                        }

                        c2--;
                        n++;

                    }

                    m++;
                    c1--;

                    c2 = 3;
                    n = -1;

                }

            }

        }

        public Spot GetSpotAt(int x, int y)
        {
            return this.spotlist[x,y];
        }

        public int GetLength() 
        {
            return this.spotlist.GetLength(0);
        }

    }
}
