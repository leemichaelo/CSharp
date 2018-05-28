﻿
namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //Ternary If statement
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}