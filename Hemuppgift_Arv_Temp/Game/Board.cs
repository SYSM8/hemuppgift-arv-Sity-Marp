using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        private int noPins { get; set; }


        public void SetUp(int value)
        {
            noPins = value;
        }

        public int getNoPins()
        {
            return noPins;
        }

        public void TakePins(int pins)
        {
            Console.WriteLine($"You take {pins}");
            noPins -= pins;
        }


    }
}
