using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board(10);
            Player human = new Player("TureTurk1");
            Player comp = new ComputerPlayer("NPC");
            Player thisPlayer = human;

            while (board.getNoPins() > 0)
            {
                Console.WriteLine("Ange antalet pinnar att ta (1 eller 2):");
                string user = Console.ReadLine();

                if (board.getNoPins() == 0)
                {
                    Console.WriteLine($"{thisPlayer} förlorade");

                    Player winner;
                    if (thisPlayer == human)
                    {
                        winner = comp;
                    }
                    else
                    {
                        winner = human;
                    }

                    Console.WriteLine($"{winner.Name} vann spelet.")
                        break;
                }
                if (thisPlayer == human)
                {
                    thisPlayer = comp;
                }
                else
                {
                    thisPlayer = human;
                }


            }
        }
    }
}


     