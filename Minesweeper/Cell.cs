using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IContent Content { get; set; }
        public IState State { get; set; }
        public bool IsUncovered { get; set; }
        public bool IsBomb { get; set; }
        public bool IsMarked { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            State = new CoveredCellState(this);
        }
        public void Uncover()
        {
            State.Uncover();
        }

        public void Mark()
        {
            State.Mark();
        }

        public void Unmark()
        {
            State.Unmark();
        }
    }
}
