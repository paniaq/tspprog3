using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace BuscaminasGame
{
    [Serializable]
    public class Game : IGame
    {
        private Board board;
        private Difficulty difficulty;

        //Constructor
        public Game()
        {

        }

        public Board GetBoard()
        {
            return this.board;
        }

        public void NewGame(Difficulty difficulty) {

            this.difficulty = difficulty;

            this.board = new Board(difficulty);
            this.board.InitBoard();

        }

        public void SaveGameState()
        {

            string currentDir = Directory.GetCurrentDirectory().ToString();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(currentDir + "/game.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
            
        }

        public IGame ResumeGame() 
        {
            string currentDir = Directory.GetCurrentDirectory().ToString();

            IGame game = null;

            if (File.Exists(currentDir + "/game.bin") || new FileInfo(currentDir + "/game.bin").Length == 0) 
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(currentDir + "/game.bin",
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.Read);
                game = (Game)formatter.Deserialize(stream);
                stream.Close();
            }

            return game;

        }

        public bool Click(int x, int y, bool flag) {

            if (!flag)
            {

                ICascadable discoveredSpot = this.board.GetSpotAt(x, y);

                //this.board.GetSpotAt(x, y).Discover();

                return discoveredSpot.Cascade(this.board);

            }
            else 
            {
                Spot spotToFlag = this.board.GetSpotAt(x, y);
                spotToFlag.ToggleFlag();
                return true;
            }


        }

        public void GameOver() 
        {
            for (int i = 0; i < this.board.GetLength(); i++)
            {
                for (int j = 0; j < this.board.GetLength(); j++)
                {

                    if(this.board.GetSpotAt(i,j).HasFlag()) 
                    {
                        this.board.GetSpotAt(i, j).ToggleFlag();                        
                    }

                    this.board.GetSpotAt(i, j).Discover();

                }
            }
        }

        

    }
}
