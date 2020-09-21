﻿using System;

namespace TheMaze
{
    class Program
    {
        static bool isRunning = true;  // Menu: TODO the menu
        static void Main(string[] args)
        {
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Maze");
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1) Play the game");
                Console.WriteLine("2) How to play");
                Console.WriteLine("3) High score");
                Console.WriteLine("Q) Quit the program");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey menuInput = keyInfo.Key;

                switch (menuInput)
                {
                    case ConsoleKey.D1:
                        Game newGame = new Game();
                        newGame.Start();
                        break;
                    case ConsoleKey.D2:
                        // TODO: Instructions();
                        break;
                    case ConsoleKey.D3:
                        // TODO: HighScore();
                        break;
                    case ConsoleKey.Q:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please enter an option from the menu.");
                        break;
                }
            }


        }
    }
}
