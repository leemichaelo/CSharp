using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            //Compared Y to X to get the list in asc order ( * -1 is another way to do it)
            return y.PointsPerGame.CompareTo(x.PointsPerGame);
        }
    }
}
