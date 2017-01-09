using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Game
    {

        public int Side { get; set; }
        public Cell[,] Cells { get; set; }
        public Game(int side)
        {
            Side = side;
            Cells = new Cell[side, side];
        }
    }
}
