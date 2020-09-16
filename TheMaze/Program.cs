using System;

namespace TheMaze
{
    class Program
    {
        static bool isRunning = true;
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Start();
        }
    }
}
