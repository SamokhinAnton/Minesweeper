﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public interface IContent
    {
        void Uncover();

        bool IsBomb { get; }
    }
}
