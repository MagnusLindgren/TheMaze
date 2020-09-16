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
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" },
            };
            int rows = mapGrid.GetLength(0);
            int columns = mapGrid.GetLength(1);
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    string draw = mapGrid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(draw);
                }
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();        }
    }
}
