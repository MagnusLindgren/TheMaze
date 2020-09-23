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

        public bool IsPassable(int x, int y) // Check if players paths is passable
        {
            if (x < 0 || y < 0 || x > Columns || y > Rows)
            {
                return false;
            }
            return MapGrid[y, x] == " " || MapGrid[y, x] == "X";
        }

        public string GetPosition(int x, int y) // Check where anything is
        {
            return MapGrid[y, x];
        }

        public static int MathQuiz() // Move to  own class when and if done
        {
            int tries = 1;
            while (true)
            {
                Random rng = new Random();
                int playerAnswer = 0;
                int x = rng.Next(1, 10);
                int y = rng.Next(1, 10);
                int result = x * y;
                Console.WriteLine("What is {0} * {1}?", x, y);
                while (true)
                {                   
                    Console.Write("Answer: ");
                    playerAnswer = Int32.Parse(Console.ReadLine()); 

                    if (playerAnswer == result)
                    {
                        tries++;
                        Console.WriteLine("Congrats, you beaten the monster!\n\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        tries++;
                        if (tries > 3)
                        {
                            Console.WriteLine("You died!!!\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("The monster is one step closer. Please try again...");
                        Console.WriteLine("You have {0} tries left", 4 - tries);
                    }
                }
                break;
            }
            return tries;
        }
    }
}
