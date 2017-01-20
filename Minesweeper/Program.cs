using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //var side = 30;
            //var bombs = 30;
            //Console.WindowWidth = side + 2;
            //Console.WindowHeight = side + 10;
            //var game = new Game(side, bombs);
            //game.Start();
            GameMenu.Menu();
        }
    }
}
