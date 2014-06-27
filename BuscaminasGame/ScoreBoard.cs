using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public class ScoreBoard
    {

        private string currentDir;
        private string fileName;

        public ScoreBoard() 
        {
            this.fileName = "/scoreBoard.scoreboard";
            this.currentDir = Directory.GetCurrentDirectory().ToString();
        }

        /*
         * 
         * Crea o recupera el archivo para guardar los Scores de los jugadores
         * 
        */
        public List<IPlayer> CreateOrRetrieve() 
        {

            List<IPlayer> playerList = null;

            if (File.Exists(this.currentDir + this.fileName))
            {
                string[] scores = File.ReadAllLines(this.currentDir + this.fileName);

                if (scores.Length != 0) 
                {
                    playerList = PlayerAdapter.ScoreToPlayer(scores);
                }                
            }
            else 
            {
                File.Create(this.currentDir + this.fileName);                
            }            

            return playerList;

        }

        public void SaveScore(IPlayer player) 
        {

            List<IPlayer> playerList = this.CreateOrRetrieve();

            if (playerList == null)
            {
                string[] scores = new string[1];

                scores[0] = player.Name + "@" + player.Score;

                File.WriteAllLines(this.currentDir + this.fileName, scores);
            }
            else 
            {
                playerList.Add(player);
                playerList.Sort();
                playerList.Reverse();

                string[] scores = PlayerAdapter.PlayerToScore(playerList);

                File.WriteAllLines(this.currentDir + this.fileName, scores);
            }

        }

        public void EraseScore() 
        {
            if(File.Exists(this.currentDir + this.fileName)) 
            {
                File.Delete(this.currentDir + this.fileName);
            }
        }


    }
}
