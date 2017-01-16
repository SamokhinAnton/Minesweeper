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
            var side = 30;
            var bombs = 30;
            var view = new GameView(new Game(side, bombs));
            view.Start();
            

            //Console.ForegroundColor = ConsoleColor.Blue;
            //var c1 = (char)0x255A;
            //var c2 = (char)0x2557;
            //var c3 = (char)0x255D;
            //var c4 = (char)0x2554;
            //var v = (char)0x2551;
            //var h = (char)0x2550;

            //var a = 25;
            //Console.Write(c4);
            //for (int i = 1; i < a; i++)
            //{
            //    Console.Write(h);
            //}
            //Console.Write(c2);
            //Console.WriteLine();
            //for (int i = 1; i < a; i++)
            //{
            //    Console.SetCursorPosition(0, i);
            //    Console.Write(v);
            //    Console.SetCursorPosition(a, i);
            //    Console.Write(v);
            //}
            //Console.SetCursorPosition(0, a);
            //Console.Write(c1);
            //for (int i = 1; i < a; i++)
            //{

            //    Console.Write(h);
            //}
            //Console.Write(c3);
            //Console.ResetColor();
            //Console.CursorVisible = true;
            //Console.CursorSize = 50;
            //for (int i = 1; i < a; i++)
            //{
            //    for (int j = 1; j < a; j++)
            //    {
            //        Console.SetCursorPosition(i,j);
            //        Console.Write("*");
            //    }
            //}

            //var xPos = Console.CursorLeft;
            //var yPos = Console.CursorTop;
            //while (true)
            //{
            //    var key = Console.ReadKey(true);
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.DownArrow:
            //            Console.SetCursorPosition(xPos, yPos += 1);
            //            break;
            //        case ConsoleKey.UpArrow:
            //            Console.SetCursorPosition(xPos, yPos -= 1);
            //            break;
            //        case ConsoleKey.RightArrow:
            //            Console.SetCursorPosition(xPos += 1, yPos);
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            Console.SetCursorPosition(xPos -= 1, yPos);
            //            break;
            //        default:
            //            break;
            //    }
            //}

        }
    }
}
