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
        public bool IsBomb
        {
            get
            {
                return true;
            }
        }

        public void Uncover()
        {
            End();
        }
    }
}
