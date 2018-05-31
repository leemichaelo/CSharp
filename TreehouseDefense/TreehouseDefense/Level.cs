using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set;  }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns true if the player wins, false other wise
        public bool Play()
        {           
            int remainingInvaders = _invaders.Length;

            //Run until all invaders are neutrilized or an invader reaches the nd of the path
            while (remainingInvaders > 0)
            {
                //Each tower has an opportunity to fire on an invader
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                //Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;                       
                    }
                }
            }
            return true;
        }
    }
}
