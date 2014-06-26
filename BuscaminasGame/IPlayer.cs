using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IPlayer
    {

        string GetName();

        int Score
        {
            get;
            set;
        }

    }
}
