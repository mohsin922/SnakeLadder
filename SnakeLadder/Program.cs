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
            return random.Next(1,7);
        }

    }
    public class ResultOfTheGame
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
            Boolean is_player_1 = true;
            int player1 = 0;
            int player2 = 0;

            InitialPositionOfPlayer positionObj = new InitialPositionOfPlayer();
            Dice dice = new Dice();


            while (player1 < 100 && player2 < 100)
            {
                int die_number = dice.dieRoll();

                switch (check())
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if (is_player_1)
                        {
                            if (player1 + die_number <= 100)
                            {
                                player1 += die_number;
                                is_player_1 = false;
                            }
                        }
                        else if (player2 + die_number <= 100)
                        {
                            player2 += die_number;
                            is_player_1 = true;
                        }
                        break;
                    case SNAKE:
                        if (is_player_1)
                        {
                            if (player1 - die_number >= 0)
                            {
                                player1 -= die_number;
                            }
                            else
                                player1 = 0;
                        }
                        else if (player2 - die_number >= 0)
                        {
                            player2 -= die_number;
                        }
                        else
                            player2 = 0;
                        break;
                }
                is_player_1 = !is_player_1;
                Console.WriteLine("Position of Player1 : " + player1);
                Console.WriteLine("Position of Player2 : " + player2);
            }
            if (player1 == 100)
                Console.WriteLine("Player1 Won the game");
            else if (player2 == 100)
                Console.WriteLine("Player2 Won the game");
        }
    }
}