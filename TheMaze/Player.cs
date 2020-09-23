using System;
using System.Collections.Generic;
using System.Text;

namespace TheMaze
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerAvatar;
        private ConsoleColor PlayerColor;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            PlayerAvatar = "¤";
            PlayerColor = ConsoleColor.Green;
        }

        public void Render()
        {
            Console.ForegroundColor = PlayerColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(PlayerAvatar);
            Console.ResetColor();
        }
    }
}
