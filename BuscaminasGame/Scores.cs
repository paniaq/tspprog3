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
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {

            ScoreBoard scoreBoard = new ScoreBoard();

            List<IPlayer> playerList = scoreBoard.CreateOrRetrieve();

            // Create an unbound DataGridView by declaring a column count.
            this.dataGridViewScores.ColumnCount = 2;
            this.dataGridViewScores.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            this.dataGridViewScores.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            this.dataGridViewScores.Columns[0].Name = "Name";
            this.dataGridViewScores.Columns[1].Name = "Score";

            // Populate the rows. 

            foreach (IPlayer player in playerList)
            {

                string[] row = { player.Name, player.Score.ToString() };

                this.dataGridViewScores.Rows.Add(row);
            }

            

        }

    }
}
