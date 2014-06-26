using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public class Game : IGame
    {
        private IPlayer player;
        private IBoard board;

        //Constructor
        public Game(IPlayer player)
        {
            this.player = player;
        }

        public IPlayer GetPlayer()
        {
            return this.player;
        }

        public IBoard GetBoard()
        {
            return this.board;
        }

        public void NewGame(Difficulty difficulty) {

            this.board = new Board(difficulty);

        }

        public bool Click(int x, int y) {

            ICascadable discoveredSpot = this.board.GetSpotAt(x, y);

            return discoveredSpot.Cascade(this.board);

        }
    }
}
