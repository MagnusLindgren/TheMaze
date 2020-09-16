using System;
using System.Collections.Generic;
using System.Text;

namespace TheMaze
{
    class Maze
    {
        private string[,] MapGrid;
        private int Rows;
        private int Columns;

        public Maze(string[,] mapGrid)
        {
            MapGrid = mapGrid;
            Rows = mapGrid.GetLength(0);
            Columns = mapGrid.GetLength(1);
        }

        public void DrawMap()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    string draw = MapGrid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(draw);
                }
            }
        }

        public bool IsPassable(int x, int y)
        {
            return MapGrid[y, x] == " ";
        }
    }
}
