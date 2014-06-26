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

        private int runs = 0;

        public Form1()
        {
            InitializeComponent();            

            int x = 40;
            int y = 40;

            this.boardSize = 20;
            this.grid = new Button[boardSize, boardSize];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    //Create new Button
                    System.Windows.Forms.Button spot = new System.Windows.Forms.Button();

                    //Set Properties
                    spot.Location = new System.Drawing.Point(x, y);

                    spot.Name = "Spot[" + i + "," + j + "]";
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

        private void Button_Click_Spot(object sender, EventArgs e) 
        {

            Button thisButton = (Button)sender;

            thisButton.Enabled = false;

            this.RedrawBoard();

        }

        private void RedrawBoard() 
        {
            for (int i = 0; i < this.boardSize; i++)
            {

                for (int j = 0; j < this.boardSize; j++)
                {
                    
                    this.grid[i, j].Text = this.runs.ToString();
                    

                }

            }

        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {

            this.player = new Player("Gabril");
            this.game = new Game(player);
            this.game.NewGame(new Difficulty(8, 50));

            MessageBox.Show(game.GetBoard().ToString());

        }

    }
}
