using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class SuperComputerPlayer(string userId) : Player(userId)
    {
        public override int TakePins(Board board)
        {

            Random rand = new Random();
            int totalPins = board.getNoPins(); // Get the amount of pins

            int rndNmbr;

            // if there are 4 pins left, take 1.
            if (totalPins == 4)
            {
                rndNmbr = 1;
            }
            // If there are 3 pins left, take 2
            else if (totalPins == 3)
            {
                rndNmbr = 2;
            }
            //etc
            else if (totalPins == 2)
            {
                rndNmbr = 1;
            }
            else if (totalPins == 1)
            {
                rndNmbr = 1; // lose
            }
            else
            {
                // else randoms between 1 and two.
                rndNmbr = rand.Next(1, 3);
            }

            board.TakePins(rndNmbr);
            Console.WriteLine($"Computer takes {rndNmbr} pins.");
            return rndNmbr;
        }
    }
}