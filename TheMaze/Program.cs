using System;

namespace TheMaze
{
    class Program
    {
        static bool isRunning = true;  // Menu: TODO the menu
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Start();
        }
    }
}
