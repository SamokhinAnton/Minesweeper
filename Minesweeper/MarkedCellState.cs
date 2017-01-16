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
            Cell.IsMarked = false;
            Cell.State = new CoveredCellState(Cell);
        }

        public override char View
        {
            get
            {
                return (char)0x0489;
            }
        }
    }
}
