namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        static void Main(string[] args)
        {
            // creates an object of the Board class
            Board GameBoard = new Board();


            //user input for how many pins there should be.
            Console.WriteLine("How many pins this round?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int PinNmbr))
            {
                GameBoard.SetUp(PinNmbr);
            }
            else
            {
                Console.WriteLine("invalid input");
            }


            Player player1 = new HumanPlayer("bob");
            Player player2 = new ComputerPlayer("beb");
            Player currentPlayer = player1;


            //The game's main loop that runs as long as there are still pins.
            while (GameBoard.getNoPins() > 0)
            {
                Console.WriteLine($"Pins remaining: {GameBoard.getNoPins()}");
                int pinsTaken = currentPlayer.TakePins(GameBoard);

                if (GameBoard.getNoPins() == 0)
                {
                    Console.WriteLine($"{currentPlayer.userId} took the last pin, {currentPlayer.userId} loses.");
                }

                currentPlayer = (currentPlayer == player1) ? player2 : player1; // Switch between players after taking a turn.
            }

        }
    }
}
