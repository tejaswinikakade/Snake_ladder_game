using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class UC6
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
            int i = 1;
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


                    int m = 0;

                    if (position > 100)
                    {

                        Console.WriteLine("More than 100 try again");
                        position -= dice1;
                        m = 2;
                    }
                    else if (position == 100)
                    {
                        m = 1;
                    }


                    switch (m)
                    {
                        case 1:
                            {
                                Console.WriteLine("Congratulations! Finally reached to 100");
                                Console.WriteLine("Position is " + position);
                                break;
                            }
                        case 2:
                            {
                                while (position == 100)
                                {
                                    Random random2 = new Random();
                                    int outcomeNew = random2.Next(1, 7);

                                    Console.WriteLine("Back to the previous position : " + position);
                                    position += outcomeNew;
                                    Console.WriteLine("new outcome" + outcomeNew);
                                    Console.WriteLine("New position is : " + position);

                                }

                                break;
                            }
                        default:
                            {

                                break;
                            }

                    }


                }

                else
                {
                    Console.WriteLine("Stay at the same position !");
                    Console.WriteLine("Your position is : " + position);
                }
                i++;
                Console.WriteLine("Move number :" + i);

            }
        }
    }
}
