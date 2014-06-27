using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IGame
    {

        void NewGame(Difficulty difficulty);

        void SaveGameState();

        IGame ResumeGame();

        Board GetBoard();

        bool Click(int x, int y, bool flag);

        void GameOver();        

    }
}
