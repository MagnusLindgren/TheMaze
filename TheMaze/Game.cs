using System;
using System.Collections.Generic;
using System.Text;

namespace TheMaze
{
    class Game
    {
        private Maze NewMaze;
        private Player NewPlayer;

        public void Start()
        {
            Console.CursorVisible = false;
            // TODO more levels/maps
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

            NewMaze = new Maze(mapGrid);
            NewPlayer = new Player(1, 1);

            PlayGame();


            //Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        private void PlayGame()
        {
            while (true)
            {
                RenderGameFrame();
                PlayerControl();

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
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKey playerInput = keyInfo.Key;

            switch (playerInput)
            {
                case ConsoleKey.W:
                    if (NewMaze.IsPassable(NewPlayer.X, NewPlayer.Y - 1))
                    {
                        NewPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.S:
                    if (NewMaze.IsPassable(NewPlayer.X, NewPlayer.Y + 1))
                    {
                        NewPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.A:
                    if (NewMaze.IsPassable(NewPlayer.X - 1, NewPlayer.Y ))
                    {
                        NewPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.D:
                    if (NewMaze.IsPassable(NewPlayer.X + 1, NewPlayer.Y ))
                    {
                        NewPlayer.X += 1;
                    }
                    break;
            }
                
        }
    }
}
