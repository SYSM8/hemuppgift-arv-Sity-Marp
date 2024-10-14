using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId) { }

        public override int TakePins(Board board)
        {
            Random rand = new Random();
            int rndNmbr = rand.Next(1, 3); //random 1 to 2.
            board.TakePins(rndNmbr);
            Console.WriteLine($"Computer takes {rndNmbr} pins.");
            return rndNmbr;
        }
    }
}
