using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TheMaze
{
    class Game
    {
        public static bool gameOn = true;
        private Maze NewMaze;
        private Player NewPlayer;

        public void Start()
        {
            Console.Title = "The Maze";
            Console.CursorVisible = false;

            string[,] mapGrid = LevelBuilder.BuildLevel("Level1.txt");
            /*
            string[,] mapGrid =
            {
                {"▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄" },
                {"█", " ", "█", "█", " ", "█", " ", "█" },
                {"█", " ", "█", " ", " ", " ", " ", "█" },
                {"█", " ", "█", "█", " ", "█", " ", "█" },
                {"█", " ", " ", " ", " ", "█", " ", "█" },
                {"█", " ", "█", " ", " ", "█", " ", "X" },
                {"▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀" },
            };
            */
            // TODO: Move maps to possible textfiles and add more of them(maybe bigger)
            NewMaze = new Maze(mapGrid);
            NewPlayer = new Player(1, 1);

            PlayGame();

            //Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        private void PlayGame() // The gameloop
        {
            while (gameOn)
            {
                RenderGameFrame();
                PlayerControl();
                string elemantAtPlayer = NewMaze.GetPosition(NewPlayer.X, NewPlayer.Y);
                if (elemantAtPlayer == "X")
                {
                    break;
                }
                System.Threading.Thread.Sleep(33);
            }
        }

        private void RenderGameFrame()
        {
            Console.Clear();
            NewMaze.RenderMap();
            NewPlayer.Render();
        }

        private void PlayerControl()
        {
            ConsoleKey playerInput;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                playerInput = keyInfo.Key;
            } while (Console.KeyAvailable);

            switch (playerInput)
            {
                case ConsoleKey.UpArrow:
                    if (NewMaze.IsPassable(NewPlayer.X, NewPlayer.Y - 1))
                    {
                        NewPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (NewMaze.IsPassable(NewPlayer.X, NewPlayer.Y + 1))
                    {
                        NewPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (NewMaze.IsPassable(NewPlayer.X - 1, NewPlayer.Y ))
                    {
                        NewPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (NewMaze.IsPassable(NewPlayer.X + 1, NewPlayer.Y ))
                    {
                        NewPlayer.X += 1;
                    }
                    break;
                case ConsoleKey.Escape:
                    gameOn = false;
                    break;
            }
        }
    }
}
