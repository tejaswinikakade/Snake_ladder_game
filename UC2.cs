using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class UC2

    {

        public int dieRoll()
        {

            Random random = new Random();
            int outcome = random.Next(1, 6);
            Console.WriteLine("outcome of die1 is " + outcome);
            return outcome;
        }
    }
}
