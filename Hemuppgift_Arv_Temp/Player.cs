using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{

        public abstract class Player 
        {

            public string Name {  get; set; }
            private string Winner { get; set; }

            public Player(string name)
            { 
                Name = name;
                
            
            }

            public abstract int takePins(Board board);



        }

        public class HumanPlayer : Player
        {
            public HumanPlayer(string name) : base(name) { }

            public override int takePins(Board board)
            {
                Console.WriteLine($"{Name}, Ta en pinne eller två pinnar.");
                int pins = Convert.ToInt32(Console.ReadLine());
                if (pins == 1 || pins == 2)
                {
                    return board.takePins(pins);
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning.");
                    return 0;
                }

            }
        }
            public class ComputerPlayer : Player
            {
                private Random random = new Random();

                public ComputerPlayer(string name, string winner) : base(name) { }

                public override int takePins(Board board)
                {
                    int pinsToTake = board.getNoPins() > 1 ? random.Next(1, 3) : 1;
                    Console.WriteLine($"{Name} tar {pinsToTake} pinnar.");
                    return board.takePins(pinsToTake);

                }


            }


        







    
}
