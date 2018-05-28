using System.Linq;

namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //Ternary If statement
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation location)
        {
            //return (_path.Contains(location));
            foreach (MapLocation pathLocation in _path)

            {

                if (location.X == pathLocation.X && location.Y == pathLocation.Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
