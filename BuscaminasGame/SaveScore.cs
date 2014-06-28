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
    public partial class SaveScore : Form
    {

        private int score;

        public SaveScore()
        {
            InitializeComponent();
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        private void buttonSaveScore_Click(object sender, EventArgs e)
        {

            if (this.playerName.Text == "")
            {
                return;
            }
            else 
            {

                int l = (this.playerName.Text.Length < 4) ? this.playerName.Text.Length : 4;

                IPlayer player = new Player(this.playerName.Text.Substring(0, l));
                player.Score = this.score;

                ScoreBoard scoreBoard = new ScoreBoard();
                
                scoreBoard.SaveScore(player);

                this.Close();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
