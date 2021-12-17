using System;

namespace SnakeLadder
{
    public class InitialPositionOfPlayer
    {
        int position = 0;
        static void Main(String[] args)
        {
            InitialPositionOfPlayer c1 = new InitialPositionOfPlayer();
            Console.WriteLine("Starting Position of Player is : " + c1.position);
        }
    }
}