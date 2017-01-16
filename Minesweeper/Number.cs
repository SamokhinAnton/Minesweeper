using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Number : IContent
    {
        public int Value { get; set; }

        public ConsoleColor Color()
        {
            switch (Value)
            {
                case 1:
                    return ConsoleColor.Gray;
                case 2:
                    return ConsoleColor.Cyan;
                case 3:
                    return ConsoleColor.DarkCyan;
                default:
                    return ConsoleColor.DarkMagenta;
            }
        }

        public void Increase()
        {
            Value++;
        }

        public char View
        {
            get
            {
                return ' ';
            }
        }

        public bool IsBomb
        {
            get
            {
                return false;
            }
        }

        public void Uncover()
        {
        }

     
    }
}
