using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            
            Board board = new Board(12, 25);
            
            
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

                
            }

              //Player förälderklass till Human och Computer,och syftet är att barnklasserna ska ärva egenskaper från föräldern.
              //HumanPlayer p = new HumanPlayer("Rhaenyra");
              // Arv gör att koden blir smidigare att bygga och underhålla. Sen så återanvänderman koden så att man slipper skriva om den.
              // Player gör att barnklasserna har samma struktur att följa men med lite skillnader,
              // då human är mänsklig input medan computer är automatisk. Men strukturen och slutmålet är densamma. 
           



            





        }
    }
}


     