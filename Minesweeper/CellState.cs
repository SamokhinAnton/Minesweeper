using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public abstract class CellState : IState
    {
        protected Cell Cell;

        public virtual char View
        {
            get
            {
                return ' ';
            }
        }

        public CellState(Cell cell)
        {
            Cell = cell;
        }

        public virtual void Mark()
        {
        }

        public virtual void Unmark()
        {
        }

        public virtual void Uncover()
        {
        }
    }
}
