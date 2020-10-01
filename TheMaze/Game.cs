using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Xml.Serialization;

namespace TheMaze
{
    public class Game
    {
        public static bool gameOn = true;
        private Maze NewMaze;
        private Player NewPlayer;
        public int Score;

        public void Start()
        {
            Console.Title = "The Maze";
            Console.CursorVisible = false;

            string[,] mapGrid = LevelBuilder.BuildLevel("Level1.txt");

            NewMaze = new Maze(mapGrid);
            NewPlayer = new Player(1, 1); // TODO: Set postion from txtfile.

            PlayGame();

            //Console.WriteLine("\n\nPress any key to exit...");
            //Console.ReadKey();
        }

        private void PlayGame() // The gameloop
        {
            while (gameOn)
            {
                RenderGameFrame();
                PlayerControl();
                string elemantAtPlayer = NewMaze.GetPosition(NewPlayer.X, NewPlayer.Y);
                if (elemantAtPlayer == "?")
                {
                    elemantAtPlayer.Replace("?", " ");
                    Score = Maze.CalculateScore(Score, Maze.MathQuiz());
                }
                if (elemantAtPlayer == "X")
                {
                    Score = Maze.CalculateScore(Score, Maze.MathQuiz());
                    break;
                }                
                System.Threading.Thread.Sleep(33);
            }
            EndGame();
        }

        private void RenderGameFrame()
        {
            Console.Clear();
            NewMaze.RenderMap();
            NewPlayer.Render();
        }

        private void EndGame()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("Your final score was {0}\n\nPress any key to continue...", Score);
            Console.ReadKey();
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
                case ConsoleKey.Escape: // buggigt när man kommer ut till menyn
                    Score = 0;
                    gameOn = false;
                    EndGame();
                    break;
            }
        }
    }
}
