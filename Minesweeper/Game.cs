using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {
        public int Side { get; set; }
        public List<Cell> Cells { get; set; }
        public int Bombs { get; set; }
        public bool IsGameOver { get; set; }
        public GameInit Initializetion { get; set; }
        public GameView View { get; set; }
        public bool IsWin {get;set;}
        public Game(int side, int bombs)
        {
            Side = side;
            Bombs = bombs;
            Cells = new List<Cell>();
            IsGameOver = false;
            IsWin = false;
            for (int i = 1; i <= side; i++)
            {
                for (int j = 1; j <= side; j++)
                {
                    Cells.Add(new Cell(i, j));
                }
            }

            Initializetion = new GameInit(this);
            View = new GameView(this);
        }

        public Cell FindCell(int x, int y)
        {
            return Cells.FirstOrDefault(s => s.X == x && s.Y == y);
        }

        public void Uncover(int x, int y)
        {
            FindCell(x, y).Uncover();
            var covered = Cells.Count(c => !c.IsUncovered || c.IsMarked);
            if (Bombs == covered)
            {
                Win();
            }
        }

        public void Mark(int x, int y)
        {
            FindCell(x, y).Mark();
        }

        public void Unmark(int x, int y)
        {
            FindCell(x, y).Unmark();
        }

        public void End()
        {
            foreach (var bomb in BombsCells())
            {
                bomb.Uncover();
            }
            IsGameOver = true;
            
        }

        public List<Cell> BombsCells()
        {
            return Cells.Where(s => s.IsBomb).ToList();
        }

        public List<Cell> NeighborsCell(Cell cell)
        {
            var leftNeighborCoords = cell.X == 1 ? 1 : cell.X - 1;
            var rightNeighborCoords = cell.X == Side ? Side : cell.X + 1;
            var upNeighborCoords = cell.Y == 1 ? 1 : cell.Y - 1;
            var bottomNeighborCoords = cell.Y == Side ? Side : cell.Y + 1;

            return Cells.Where(s => s != cell
                            && s.X >= leftNeighborCoords && s.X <= rightNeighborCoords
                            && s.Y >= upNeighborCoords && s.Y <= bottomNeighborCoords
                            ).ToList();
        }

        public List<Cell> NullCell()
        {
            return Cells.Where(s => s.Content == null).ToList();
        }

        public void Start()
        {
            Initializetion.Init();
            View.Start();
        }

        public void Win()
        {
            IsWin = true;
            IsGameOver = true;
        }
    }
}
