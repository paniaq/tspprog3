using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BuscaminasGame
{
    public partial class Form1 : Form
    {
        private IGame game;
        private int boardSize;
        private Button[,] grid;
        private Timer timer;
        private int ElapsedTime;
        private int score;
        private int flags;

        public Form1()
        {

            InitializeComponent();

            this.ElapsedTime = 0;
            this.score = 0;

            this.timer = new Timer();

            this.timer.Interval = 1000;

            this.timer.Tick += timer_Tick;

            this.game = new Game().ResumeGame();

            if(this.game != null) 
            {
                this.ElapsedTime = this.game.Time;
                this.InitGrid();
                this.RedrawBoard();
                this.timer.Start();
                this.flags = this.game.AvailableFlags();
                this.labelFlags.Text = this.flags.ToString();
            }

        }

        private void Button_Click_Spot(object sender, EventArgs e) 
        {

            

            Button button = (Button)sender;

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

                    this.score = 0;
                    this.labelScore.Text = this.score.ToString();
                    this.timer.Stop();
                    this.game.GameOver();
                    MessageBox.Show("YOU LOSE!");                    

                }
                
            }
            else if(((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right)
            {

                if (this.game.GetBoard().GetSpotAt(x, y).HasFlag())
                {
                    this.flags++;
                    this.labelFlags.Text = this.flags.ToString();
                }
                else if (!this.game.GetBoard().GetSpotAt(x, y).HasFlag())  
                {

                    if(this.flags == 0) 
                    {
                        return;
                    }

                    this.flags--;
                    this.labelFlags.Text = this.flags.ToString();
                }                

                if(!this.game.Click(x, y, true)) 
                {
                    if(this.game.GameOver()) 
                    {
                        this.timer.Stop();
                        MessageBox.Show("You Win");
                        this.score -= this.ElapsedTime;
                        this.score = (this.score < 0) ? 0 : this.score;

                        SaveScore saveScoreForm = new SaveScore();

                        saveScoreForm.Score = this.score;

                        saveScoreForm.ShowDialog();

                    }
                }
                

            }

            this.score--;
            this.labelScore.Text = this.score.ToString();

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

        public void InitGrid() 
        {
            this.boardSize = this.game.GetBoard().GetLength();

            int x = 20;
            int y = 50;

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
                x = 20;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.game != null)
            {
                this.game.SaveGameState(this.ElapsedTime);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            this.ElapsedTime++;
            this.labelTimer.Text = this.ElapsedTime.ToString();

        }

        public void NewGame(int spots, int mines) 
        {
            if (this.grid != null)
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
            this.game.NewGame(new Difficulty(spots, mines));

            this.InitGrid();

            this.flags = this.game.AvailableFlags();
            this.labelFlags.Text = this.flags.ToString();

            this.ElapsedTime = 0;
            this.timer.Start();
        }

        private void saveQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.game != null)
            {
                this.game.SaveGameState(this.ElapsedTime);
            }

            this.Close();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.score = 200;
            this.labelScore.Text = this.score.ToString();
            this.NewGame(4,999);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.score = 300;
            this.NewGame(8,999);
            this.labelScore.Text = this.score.ToString();
        }

        private void hardcoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.score = 500;
            this.NewGame(15,999);
            this.labelScore.Text = this.score.ToString();
        }

        private void scoreScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scores scoreForm = new Scores();

            scoreForm.ShowDialog();
        }

    }
}
