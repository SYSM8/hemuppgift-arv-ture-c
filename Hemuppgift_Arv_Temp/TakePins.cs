using System.Linq.Expressions;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board(10);
            while (board.getNoPins() > 0)
            {
                Console.WriteLine("Ange antalet pinnar att ta (1 eller 2):");
                string user = Console.ReadLine();

                try
                {
                    int takePins = Convert.ToInt32(user);
                    if (takePins == 1 || takePins == 2)
                    {
                        int remainingPins = board.takePins(takePins);
                        if (remainingPins == 0)
                        {
                            Console.WriteLine("Spelet är avslutat.");
                            break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");



                }

               
            }
        }
    }
}


     