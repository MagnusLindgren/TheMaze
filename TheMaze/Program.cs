using System;
using System.Threading;
using System.IO;

namespace TheMaze
{
    class Program
    {
        static bool isRunning = true;  // Menu: TODO the menu
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 40);
            while (isRunning)
            {
                Console.Clear();
                Console.CursorVisible = false;
                RunText(@"C:\Users\mange\source\repos\TheMaze\TheMaze\TitleMenu.txt");
                Console.WriteLine("\n\nPlease choose an option:");
                Console.WriteLine("1) Play the game");
                Console.WriteLine("2) Intructions");
                Console.WriteLine("3) High score");
                Console.WriteLine("4) Rapport");
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
                        Console.WriteLine("Not implemented yet!");
                        // TODO: Instructions();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Not implemented yet!");
                        // TODO: HighScore();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        RunText(@"C:\Users\mange\source\repos\TheMaze\TheMaze\Rapport.txt");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Q:
                        isRunning = false;
                        break;
                    case ConsoleKey.D0: // EasterEgg ;)
                        Piano();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please enter an option from the menu.");
                        break;
                }
            }
        }

        static void RunText(string path) //Read and display text from txt file
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                String read = sr.ReadLine();
                while (read != null)
                {
                    Console.WriteLine(read);
                    read = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
        }

        static void Piano() // LjudTest
        {
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(25);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(25);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
        }
    }           
}
