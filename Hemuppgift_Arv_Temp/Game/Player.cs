using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal abstract class Player : Board
    {
        public string userId { get; set; }


        public Player (string userId)
        {
            this.userId = userId;
        }

        public string GetUserId()
        {
            return userId;
        }

        public abstract int TakePins(Board board);

    }
}
