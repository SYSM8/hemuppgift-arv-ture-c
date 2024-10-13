using Hemuppgift_Arv_Temp;
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

                public ComputerPlayer(string name) : base(name) { }

                public override int takePins(Board board)
                {
                    int ComputerTake = random.Next(1,3);
                    Console.WriteLine($"{Name} tar {ComputerTake} pinnar.");
                    return board.takePins(ComputerTake);

                }


            }


        







    
}
