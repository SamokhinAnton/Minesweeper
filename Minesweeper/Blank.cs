using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Blank : IContent
    {
        public bool IsBomb
        {
            get
            {
                return false;
            }
        }

        public void Uncover()
        {
        }
    }
}
