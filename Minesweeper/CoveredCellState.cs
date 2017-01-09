using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class CoveredCellState : CellState
    {
        public CoveredCellState(Cell cell) : base(cell)
        {
        }

        public override void Uncover()
        {
            Cell.State = new UncoveredCellState(Cell);
            Cell.IsUncovered = true;
            Cell.Content.Uncover();
        }

        public override void Mark()
        {
            base.Mark();
        }
    }
}
