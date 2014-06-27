using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaminasGame
{
    public interface IPlayer : IComparable<IPlayer>
    {

        string Name 
        {
            get;
            set;
        }

        int Score
        {
            get;
            set;
        }

    }
}
