using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Bomb : IContent
    {
        public Action End;
        public Bomb(Action endGame)
        {
            End = endGame;
        }
        public bool IsBomb
        {
            get
            {
                return true;
            }
        }
        public char View
        {
            get
            {
                return (char)0x263B;
            }
        }

        public void Uncover()
        {
            End();
        }
    }
}
