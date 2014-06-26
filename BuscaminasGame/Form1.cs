using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuscaminasGame
{
    public partial class Form1 : Form
    {
        private IGame game;
        private IPlayer player;
        private int boardSize;
        private Button[,] grid;

        public Form1()
        {
            InitializeComponent();            

            

        }

        private void Button_Click_Spot(object sender, EventArgs e) 
        {

            Button button = (Button)sender;

            button.Enabled = false;

            //TODO: Arreglar esta cagada, substring de [ a , y de , a ]

            int index = button.Name.IndexOf("[");
            string sX = button.Name.Substring(index + 1,2);

            index = button.Name.IndexOf(",");
            string sY = button.Name.Substring(index + 1, 2);            

            this.game.Click(int.Parse(sX), int.Parse(sY));

            this.RedrawBoard();            
            

        }

        private void RedrawBoard() 
        {
            for (int i = 0; i < this.boardSize; i++)
            {

                for (int j = 0; j < this.boardSize; j++)
                {

                    if(this.game.GetBoard().GetSpotAt(i,j).IsDiscovered()) 
                    {

                        this.grid[i, j].Enabled = false;

                        if (this.game.GetBoard().GetSpotAt(i, j) is SafeSpot)
                        {
                            this.grid[i, j].Text = ((SafeSpot)this.game.GetBoard().GetSpotAt(i, j)).Mines.ToString();
                        }
                        else 
                        {
                            this.grid[i, j].Text = "M";
                        }

                    }                        

                }

            }

        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {

            this.player = new Player("Gabril");
            this.game = new Game(player);
            this.game.NewGame(new Difficulty(15, 50));

            this.boardSize = this.game.GetBoard().GetLength();

            int x = 40;
            int y = 40;

            this.grid = new Button[boardSize, boardSize];

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {

                    //Create new Button
                    System.Windows.Forms.Button spot = new System.Windows.Forms.Button();

                    //Set Properties
                    spot.Location = new System.Drawing.Point(x, y);

                    spot.Name = "Spot[" + i + " ," + j + " ]";
                    spot.Size = new System.Drawing.Size(24, 24);
                    spot.TabIndex = 0;
                    spot.Text = "";
                    spot.UseVisualStyleBackColor = true;

                    //Add Button
                    this.Controls.Add(spot);

                    spot.Click += new System.EventHandler(this.Button_Click_Spot);

                    this.grid[i, j] = spot;

                    x += 22;

                }

                y += 22;
                x = 40;
            }

        }

    }
}
