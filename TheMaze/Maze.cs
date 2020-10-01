using System;
using System.Collections.Generic;
using System.Text;

namespace TheMaze
{
    public class Maze
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
                    else if (render == "?")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
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
            return MapGrid[y, x] == " " || MapGrid[y, x] == "X" || MapGrid[y, x] == "?";
        }

        public string GetPosition(int x, int y) // Check where anything is
        {
            return MapGrid[y, x];
        }

        public static int MathQuiz() // Move to  own class when and if done
        {
            Console.Clear();
            int tries = 3;
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
                        Console.WriteLine("Congrats, you got {0} points!\n\nPress any key to continue...", tries);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        tries--;
                        if (tries < 1)
                        {
                            Console.WriteLine("No points!!!\n\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Wrong, please try again... ");
                        Console.WriteLine("You have {0} tries left", tries);
                    }
                }
                break;
            }
            return tries;
        }

        static public int CalculateScore(int x, int y)
        {
            return x + y;
        }
    }
}
