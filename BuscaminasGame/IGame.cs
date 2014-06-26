using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IGame
    {

        void NewGame(Difficulty difficulty);

        IPlayer GetPlayer();

        IBoard GetBoard();

        bool Click(int x, int y);

    }
}
