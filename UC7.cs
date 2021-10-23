using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class UC7
    {
        public static int Player1 = 1;
        public static int Player2 = 2;
        public static int position1 = 0;
        public static int position2 = 0;
        public static int move1 = 0;
        public static int move2 = 0;
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
        public int Check1()
        {
            int i = 1;
            while (position1 < 100)
            {
                int dice1 = Die1();
                int dice2 = Die2();


                if (position1 < 0)
                {
                    position1 = 0;
                    Console.WriteLine("Score is too low ! Start again Player1");
                }


                if (dice2 == SNAKE)
                {
                    Console.WriteLine("Sorry! You have to go back " + dice1 + " steps");
                    position1 -= dice1;
                    Console.WriteLine("Position1 is : " + position1);
                }
                else if (dice2 == LADDER)
                {

                    Console.WriteLine("You can move1 ahead " + dice1 + " steps");
                    position1 += dice1;
                    Console.WriteLine("Position1 is : " + position1);

                    if (position1 < 100)
                    {
                        Console.WriteLine("got 1 chance more ");
                        Console.WriteLine("You can move1 ahead " + dice1 + " steps");
                        position1 += dice1;
                        Console.WriteLine("Position1 is : " + position1);
                    }

                    int y = 0;

                    if (position1 > 100)
                    {

                        Console.WriteLine("More than 100 try again");
                        position1 -= dice1;
                        y = 2;
                    }
                    else if (position1 == 100)
                    {
                        y = 1;
                    }


                    switch (y)
                    {
                        case 1:
                            {
                                Console.WriteLine(" Player1 ! Reached to 100");

                                break;
                            }
                        case 2:
                            {
                                while (position1 == 100)
                                {
                                    Random random2 = new Random();
                                    int outcomeNew = random2.Next(1, 7);

                                    Console.WriteLine("Back to the previous position1 : " + position1);
                                    position1 += outcomeNew;
                                    Console.WriteLine("new outcome" + outcomeNew);
                                    Console.WriteLine("New position1 is : " + position1);

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
                    Console.WriteLine("Stay at the same position1 !");

                }




                i++;
                Console.WriteLine("Move number :" + i);
                move1 = i;

            }
            return move1;
        }

        public int Check2()
        {
            int i = 1;
            while (position2 < 100)
            {
                int dice1 = Die1();
                int dice2 = Die2();

                if (position2 < 0)
                {
                    position2 = 0;
                    Console.WriteLine("Score is too low ! Start again player2");
                }

                if (dice2 == SNAKE)
                {
                    Console.WriteLine("Sorry! You have to go back " + dice1 + " steps");
                    position2 -= dice1;
                    Console.WriteLine("Position2 is : " + position2);
                }
                else if (dice2 == LADDER)
                {

                    Console.WriteLine("You can move1 ahead " + dice1 + " steps");
                    position2 += dice1;
                    Console.WriteLine("Position2 is : " + position2);

                    if (position2 < 100)
                    {
                        Console.WriteLine("got 1 chance more ");
                        Console.WriteLine("You can move ahead " + dice1 + " steps");
                        position2 += dice1;
                        Console.WriteLine("Position2 is : " + position2);
                    }

                    int m = 0;

                    if (position2 > 100)
                    {

                        Console.WriteLine("More than 100 try again");
                        position2 -= dice1;
                        m = 2;
                    }
                    else if (position2 == 100)
                    {
                        m = 1;
                    }


                    switch (m)
                    {
                        case 1:
                            {
                                Console.WriteLine("Player2 ! Reached to 100");


                                break;
                            }
                        case 2:
                            {
                                while (position2 == 100)
                                {
                                    Random random2 = new Random();
                                    int outcomeNew = random2.Next(1, 7);

                                    Console.WriteLine("Back to the previous position1 : " + position2);
                                    position2 += outcomeNew;
                                    Console.WriteLine("new outcome" + outcomeNew);
                                    Console.WriteLine("New position2 is : " + position2);

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

                }




                i++;
                Console.WriteLine("Move number :" + i);
                move2 = i;

            }
            return move2;
        }
    }
}
    
