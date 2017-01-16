using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Blank : IContent
    {
        private List<Cell> NeighborsCell;

        public Blank(List<Cell> neighborsCell)
        {
            NeighborsCell = neighborsCell;
        }

        public bool IsBomb
        {
            get
            {
                return false;
            }
        }

        public char View
        {
            get
            {
                return ' ';
            }
        }

        public void Uncover()
        {
            foreach (var cell in NeighborsCell)
            {
                cell.Uncover();
            }
        }
    }
}
