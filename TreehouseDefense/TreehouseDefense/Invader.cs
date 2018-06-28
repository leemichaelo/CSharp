using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    abstract class Invader : IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        protected virtual int StepSize { get; } = 1;
        public abstract int Health { get; protected set; }

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public Invader(Path path) => _path = path;

        //True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public void Move() => _pathStep += 1;

        public virtual void DecreaseHealth(int factor) => Health -= factor;

    }
}
