namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {

            Board GameBoard = new Board();

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

            GameBoard.TakePins(5);
            Console.WriteLine(GameBoard.getNoPins());
        }
    }
}
