using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MarkedCellState : CellState
    {
        public MarkedCellState(Cell cell) : base(cell)
        {

        }

        public override void Unmark()
        {
            base.Unmark();
        }
    }
}
