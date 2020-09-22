using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

        public void RenderMap() // Draws the map
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {                   
                    string render = MapGrid[y, x];
                    Console.SetCursorPosition(x, y);

                    if (render == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(render);
                }
            }
        }

        public bool IsPassable(int x, int y) // Check if player paths is passable
        {
            if (x < 0 || y < 0 || x > Columns || y > Rows)
            {
                return false;
            }
            return MapGrid[y, x] == " " || MapGrid[y, x] == "X";
        }

        public string GetPosition(int x, int y) // Check where the player is
        {
            return MapGrid[y, x];
        }

        public void Win()
        {
            Console.WriteLine("You Win!");
            Console.ReadKey();
        }
    }
}
