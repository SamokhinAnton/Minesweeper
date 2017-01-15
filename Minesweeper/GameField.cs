using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameField
    {
        private Game Game;
        public GameField(Game game)
        {
            Game = game;
            foreach (var item in game.Cells)
            {
                DrawCell(item.X, item.Y);
            }
        }

        private void DrawCell(int x, int y)
        {
            var cell = Game.FindCell(x, y);

            Console.Write(" ");

            WriteCell(cell);

            Console.Write(" |");
        }

        private void WriteCell(Cell cell)
        {
            if (cell.IsUncovered)
            {
                DrawContent(cell.Content);
            }
            else if (cell.IsMarked)
            {
                DrawMarker();
            }
            else
            {
                DrawCover();
            }
        }

        private void DrawContent(IContent content)
        {
            if (content.IsBomb)
            {
                DrawBomb();
            }
            else if (content is Blank)
            {
                DrawBlank();
            }
            else if (content is Number)
            {
                DrawNumber(content as Number);
            }
        }

        private void DrawNumber(Number number)
        {
            var foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(number.Value.ToString());
            Console.ForegroundColor = foreground;
        }

        private void DrawBlank()
        {
            var foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(0);
            Console.ForegroundColor = foreground;
        }

        private void DrawBomb()
        {
            var foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");
            Console.ForegroundColor = foreground;
        }

        private void DrawMarker()
        {
            var foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">");
            Console.ForegroundColor = foreground;
        }

        private void DrawCover()
        {
            Console.Write("T");
        }

        public void Drow()
        {
            Console.Clear();

        }
    }
}
