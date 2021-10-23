using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class UC4
    {
        public static int position = 0;
        public const int LADDER = 0;
        public const int SNAKE = 1;

        public int Die1()
        {
            Random random = new Random();
            int outcome = random.Next(1, 6);
            
            return outcome;

        }
        public int Die2()
        {
            Random random2 = new Random();
            int outcome2 = random2.Next(0, 3);

            return outcome2;

        }
        public void Check()
        {

            while (position < 100)
            {
                int dice1 = Die1();
                int dice2 = Die2();


                if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("Score is too low ! Start again");
                }

                if (dice2 == SNAKE)
                {
                    Console.WriteLine("Sorry! You have to go back " + dice1 + " steps");
                    position -= dice1;
                    Console.WriteLine("Your position is : " + position);
                }
                else if (dice2 == LADDER)
                {

                    Console.WriteLine("You can move ahead " + dice1 + " steps");
                    position += dice1;
                    Console.WriteLine("Your position is : " + position);
                }

                else
                {
                    Console.WriteLine("Stay at the same position !");
                    Console.WriteLine("Your position is : " + position);
                }


            }
        }
    }
}
