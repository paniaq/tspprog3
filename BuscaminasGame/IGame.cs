using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IGame
    {

        int Time
        {
            get;
            set;
        }

        bool IsOver
        {
            get;
            set;
        }

        int AvailableFlags();

        void NewGame(Difficulty difficulty);

        void SaveGameState(int time);

        IGame ResumeGame();

        Board GetBoard();

        bool Click(int x, int y, bool flag);

        bool GameOver();        

    }
}
