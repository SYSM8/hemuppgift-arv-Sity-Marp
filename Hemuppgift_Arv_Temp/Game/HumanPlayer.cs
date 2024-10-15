using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer : Player
    {

        public HumanPlayer(string userId ) : base(userId) { }


        public override int TakePins(Board board)
        {
            int pinsToTake = 0;

            while (true) // Loops until input is valid
            {
                Console.Write("Enter the number of pins to take (1 or 2): ");
                if (int.TryParse(Console.ReadLine(), out pinsToTake))
                {
                    // Check if there is only one pin left on the game board
                    if (pinsToTake == 2 && board.getNoPins() == 1)
                    {
                        Console.WriteLine("You cannot take 2 pins, only 1 pin remain.");
                        continue;
                    }

                    if (pinsToTake == 1 || pinsToTake == 2) //Checks if the input is 1 or 2
                    {
                        // Call the Board's method to take pins
                        board.TakePins(pinsToTake);
                        Console.WriteLine($"You take {pinsToTake} pins.");
                        return pinsToTake; // Return the number of pins taken
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
