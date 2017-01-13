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

        public void Increase()
        {
            Value++;
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
