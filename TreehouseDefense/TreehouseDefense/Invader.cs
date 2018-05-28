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

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; private set; } = 2;

        public Invader(Path path) => _path = path;

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor) => Health -= factor;

    }
}
