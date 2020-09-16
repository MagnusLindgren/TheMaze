using System;
using System.Collections.Generic;
using System.Text;

namespace TheMaze
{
    class Game
    {
        public void Start()
        {
            string[,] mapGrid =
            {
                {"#", "=", "=", "=", "=", "=", "=", "#" },
                {"|", "O", "|", "=", " ", "|", " ", "|" },
                {"|", " ", "|", " ", " ", " ", " ", "|" },
                {"|", " ", "|", "=", " ", "|", " ", "|" },
                {"|", " ", " ", " ", " ", "|", " ", "|" },
                {"|", " ", "|", " ", " ", "|", "X", "|" },
                {"#", "=", "=", "=", "=", "=", "=", "#" },
            };

            Maze newMaze = new Maze(mapGrid);
            newMaze.DrawMap();

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();        }
    }
}
