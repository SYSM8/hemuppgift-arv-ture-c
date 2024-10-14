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
            
            HumanPlayer human = new HumanPlayer("TureTurk1");
            ComputerPlayer comp = new ComputerPlayer("NPC");

            StartGame(board, human, comp);

             static void StartGame(Board board, Player human, Player comp)
            {
                while (board.getNoPins() > 0)
                {
                    int humanPins = human.takePins(board);
                    if (board.getNoPins() == 0)
                    {
                        Console.WriteLine($"{human.userID} vann!");
                        break;
                    }

                    int compPins = comp.takePins(board);
                    if (board.getNoPins() == 0)
                    {
                        Console.WriteLine($"{comp.userID} vann!");
                        break;
                    }

                   
                }

                Console.WriteLine("Game over!");
            }











        }
    }
}


     