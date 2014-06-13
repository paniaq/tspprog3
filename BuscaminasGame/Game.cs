using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    class Game
    {
        private Player player;
        private Board board;

        //Constructor
        public Game(Player player)
        {
            this.player = player;
        }

        public Player GetPlayer()
        {
            return this.player;
        }

        public Board GetBoard()
        {
            return this.board;
        }
    }
}
