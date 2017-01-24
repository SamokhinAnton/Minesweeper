using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameView
    {
        private Game Game;
        public GameView(Game game)
        {
            Game = game;
        }

        public void DrawBorders(int side)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var c1 = (char)0x255A;
            var c2 = (char)0x2557;
            var c3 = (char)0x255D;
            var c4 = (char)0x2554;
            var v = (char)0x2551;
            var h = (char)0x2550;

            Console.Write(c4);
            for (int i = 1; i <= side; i++)
            {
                Console.Write(h);
            }
            Console.Write(c2);
            Console.WriteLine();
            for (int i = 1; i <= side; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(v);
                Console.SetCursorPosition(side + 1, i);
                Console.Write(v);
            }
            Console.SetCursorPosition(0, side + 1);
            Console.Write(c1);
            for (int i = 1; i <= side; i++)
            {
                Console.Write(h);
            }
            Console.Write(c3);
            DrowControl();
            Console.ResetColor();
        }

        private void DrawCells()
        {
            foreach (var cell in Game.Cells)
            {
                Console.SetCursorPosition(cell.X, cell.Y);
                DrawCell(cell);
            }
            Console.ResetColor();
        }

        private void DrawCell(Cell cell)
        {
            if (cell.IsUncovered)
            {
                DrawContent(cell.Content);
            }
            else if (cell.IsMarked)
            {
                DrawMarker(cell.State.View);
            }
            else
            {
                DrawCover(cell.State.View);
            }
        }

        private void DrawContent(IContent content)
        {
            if (content.IsBomb)
            {
                DrawBomb(content.View);
            }
            else if (content is Blank)
            {
                DrawBlank(content.View);
            }
            else if (content is Number)
            {
                DrawNumber(content as Number);
            }
        }

        private void DrawNumber(Number number)
        {
            Console.ForegroundColor = number.Color();
            Console.Write(number.Value.ToString());
            Console.ResetColor();
        }

        private void DrawBlank(char view)
        {
            Console.Write(view);
        }

        private void DrawBomb(char view)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(view);
            Console.ResetColor();
        }

        private void DrawMarker(char view)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(view);
            Console.ResetColor();
        }

        private void DrawCover(char view)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(view);
            Console.ResetColor();
        }

        public void DrowControl()
        {
            Console.SetCursorPosition(0, Game.Side+3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("<U> - Uncover");
            Console.WriteLine("<M> - Marc");
            Console.WriteLine("<N> - Unmark");
        }

        public void Drow()
        {
            Console.Clear();
            DrawBorders(Game.Side);
            DrawCells();
            Console.SetCursorPosition(1, 1);
        }

        public void DrowWinMsg()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, Game.Side + 2);
            Console.WriteLine("You win");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
        public void DrowLoseMsg()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, Game.Side + 2);
            Console.WriteLine("You lose");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }


        public void Start()
        {
            Drow();
            var xPos = Console.CursorLeft;
            var yPos = Console.CursorTop;
            while (!Game.IsGameOver)
            {
                Console.SetCursorPosition(xPos, yPos);
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if(yPos < Game.Side)
                            Console.SetCursorPosition(xPos, yPos += 1);
                        break;
                    case ConsoleKey.UpArrow:
                        if(yPos > 1)
                            Console.SetCursorPosition(xPos, yPos -= 1);
                        break;
                    case ConsoleKey.RightArrow:
                        if(xPos < Game.Side)
                            Console.SetCursorPosition(xPos += 1, yPos);
                        break;
                    case ConsoleKey.LeftArrow:
                        if(xPos > 1)
                            Console.SetCursorPosition(xPos -= 1, yPos);
                        break;
                    case ConsoleKey.U:
                        Game.Uncover(xPos, yPos);
                        Drow();
                        break;
                    case ConsoleKey.M:
                        Game.Mark(xPos, yPos);
                        Drow();
                        break;
                    case ConsoleKey.N:
                        Game.Unmark(xPos, yPos);
                        Drow();
                        break;
                    default:
                        break;
                }
            }
            if (Game.IsWin)
            {
                DrowWinMsg();
            } else
            {
                DrowLoseMsg();
            }
        }
    }
}
