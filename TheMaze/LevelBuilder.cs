using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TheMaze
{
    class LevelBuilder
    {
        public static string[,] BuildLevel(string textFile)
        {
            string[] lines = File.ReadAllLines(textFile);
            string firstLine = lines[0];
            int rows = lines.Length;
            int columns = firstLine.Length;
            string[,] mapGrid = new string[rows, columns];

            for (int y = 0; y < rows; y++)
            {
                string line = lines[y];
                for (int x = 0; x < columns; x++)
                {
                    char eachChar = line[x];
                    mapGrid[y, x] = eachChar.ToString();
                }
            }

            return mapGrid;
        }
    }
}
