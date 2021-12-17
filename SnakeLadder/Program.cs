using System;

namespace SnakeLadder
{

    public class RollTheDie
    {

        public static int rollDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public static void Main(String[] args)
        {

            Console.WriteLine("Result of Dice Roll :  " + rollDie());
        }
    }
}
