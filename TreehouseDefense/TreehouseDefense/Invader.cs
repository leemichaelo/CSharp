using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public MapLocation Location { get; private set; }

        public Invader(Path path)
        {
            Location = path.GetLocationAt(_pathStep);
            _path = path;
        }

        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }
    }
}
