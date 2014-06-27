using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public static class PlayerAdapter
    {

        public static List<IPlayer> ScoreToPlayer(string[] scores) 
        {

            if(scores == null || scores.Length == 0) 
            {
                return null;
            }

            List<IPlayer> playerList = new List<IPlayer>();

            for (int i = 0; i < scores.Length; i++)
            {

                string name = scores[i].Substring(0,scores[i].IndexOf("@"));
                int score = int.Parse(scores[i].Substring(scores[i].IndexOf("@") + 1));

                IPlayer player = new Player(name);
                player.Score = score;

                playerList.Add(player);
            }

            return playerList;

        }

        public static string[] PlayerToScore(List<IPlayer> playerList) 
        {
            string[] scores = null;

            if(playerList.Count == 0 || playerList == null) 
            {
                return null;
            }

            scores = new string[playerList.Count];

            for (int i = 0; i < playerList.Count; i++)
            {
                scores[i] = playerList[i].Name + "@" + playerList[i].Score;
            }

            return scores;

        }

    }
}
