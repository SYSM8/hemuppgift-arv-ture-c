namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board(10);
            int takepinne = int.Parse(Console.ReadLine());
            board.takePins(takepinne);
        }



    }
}   