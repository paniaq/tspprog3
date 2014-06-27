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
        private int boardSize;
        private Button[,] grid;

        public Form1()
        {

            InitializeComponent();

            this.game = new Game().ResumeGame();

            if(this.game != null) 
            {
                this.InitGrid();
            }

            this.RedrawBoard();

        }

        private void Button_Click_Spot(object sender, EventArgs e) 
        {

            Button button = (Button)sender;

            //TODO: Arreglar esta cagada, substring de [ a , y de , a ]

            int index = button.Name.IndexOf("[");
            string sX = button.Name.Substring(index + 1, 2);

            index = button.Name.IndexOf(",");
            string sY = button.Name.Substring(index + 1, 2);

            int x = int.Parse(sX);
            int y = int.Parse(sY);

            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {   
             
                if(this.game.GetBoard().GetSpotAt(x,y).HasFlag()) 
                {
                    return;
                }

                button.Enabled = false;

                if (!this.game.Click(x, y, false))
                {
                    MessageBox.Show("YOU LOSE!");
                    this.game.GameOver();
                    //Stop Timer Calculate Score
                }
                
            }
            else if(((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.game.Click(int.Parse(sX), int.Parse(sY), true);
            }

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
                    else if (this.game.GetBoard().GetSpotAt(i, j).HasFlag())
                    {

                        this.grid[i, j].Text = "F";

                    }
                    else 
                    {
                        this.grid[i, j].Text = "";
                    }                        

                }

            }

        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {

            if(this.grid != null) 
            {
                if (this.grid.Length != 0)
                {
                    for (int i = 0; i < this.grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < this.grid.GetLength(0); j++)
                        {
                            this.Controls.Remove(this.grid[i, j]);
                        }
                    }

                }
            }

            this.game = new Game();
            this.game.NewGame(new Difficulty(6, 50));

            this.InitGrid();            

        }

        public void InitGrid() 
        {
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

                    spot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Click_Spot);

                    this.grid[i, j] = spot;

                    x += 22;

                }

                y += 22;
                x = 40;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.game != null)
            {
                this.game.SaveGameState();
            }
        }

    }
}
