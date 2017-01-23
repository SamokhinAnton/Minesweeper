using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public static class GameMenu
    {
        public static void Menu()
        {
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("4 - Custom");
            Console.WriteLine("5 - Exit");
            var readKey = Console.ReadKey();
            var game = new Game(0, 0);
            switch (readKey.Key)
            {
                case ConsoleKey.D1:
                    game = new Game(10, 10);
                    break;
                case ConsoleKey.D2:
                    game = new Game(20, 20);
                    break;
                case ConsoleKey.D3:
                    game = new Game(30, 30);
                    break;
                case ConsoleKey.D4:
                    game = NewCustomGame();
                    break;
                default:
                    game.IsGameOver = true;
                    break;
            }
            game.Start();
        }

        public static Game NewCustomGame()
        {
            Console.Clear();
            Console.WriteLine("Enter side");
            var side = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter bombs");
            var bombs = int.Parse(Console.ReadLine());
            var game = new Game(side,bombs);
            return game;
        }
    }
}
