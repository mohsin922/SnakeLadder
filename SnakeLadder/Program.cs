using System;
namespace SnakeLadder {
    class InitialPositionOfPlayer
    {
        public int position = 0;

    }
    class Dice
    {

        public int dieRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }

    public class DieRollCount
    {

        const int NO_PLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;

        public static int check()
        {
            Random random = new Random();
            return random.Next(1,4);
        }

        public static void Main(String[] args)
        {

            int dieRolls = 0;

            InitialPositionOfPlayer positionObj = new InitialPositionOfPlayer();
            Dice dice = new Dice();


            while (positionObj.position < 100)
            {
                int die_number = dice.dieRoll();
                dieRolls += 1;

                switch (check())
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if (positionObj.position + die_number <= 100)
                        {
                            positionObj.position += die_number;
                        }
                        break;
                    case SNAKE:
                        if (positionObj.position - die_number >= 0)
                        {
                            positionObj.position -= die_number;
                        }
                        break;
                }
                Console.WriteLine("Current Position is : " + positionObj.position);
                if (positionObj.position == 100)
                {
                    Console.WriteLine("Player won the game");
                }
            }
            Console.WriteLine("Number of time die rolled is : " + dieRolls);
        }

    }
}
