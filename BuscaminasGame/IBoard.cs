using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IBoard
    {

        void InitBoard(int mines);

        Spot GetSpotAt(int x, int y);

        int GetLength();

    }
}
