﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameInit
    {

        private Game Game;

        public GameInit(Game game)
        {
            Game = game;
        }

        public void Init()
        {
            InitializeBombs();
            InitializeNumbers();
            InitializeBlank();
        }

        private void InitializeBombs()
        {
            var random = new Random();
            var bombs = Game.Cells.OrderBy(s => random.Next(Game.Cells.Count - 1)).Take(Game.Bombs);
            foreach (var bomb in bombs)
            {
                bomb.Content = new Bomb(Game.End);
            }
        }

        public void Uncover(int x, int y)
        {
            Game.Uncover(x, y);
        }
        
        private void InitializeNumbers()
        {
            var numberCells = Game.BombsCells().SelectMany(b => Game.NeighborsCell(b).Where(n => !n.IsBomb));
            foreach (var item in numberCells)
            {
                InitializeNumber(item);
            };
        }

        private void InitializeNumber(Cell cell)
        {
            if (cell.Content == null)
            {
                cell.Content = new Number() { Value = 1 };
            }
            else
            {
                var num = (Number)cell.Content;
                num.Increase();
            }
        }

        private void InitializeBlank()
        {
            var nullCells = Game.NullCell();
            foreach (var item in nullCells)
            {
                var neighbors = Game.NeighborsCell(item);
                item.Content = new Blank(neighbors);
            }
        }
    }
}
