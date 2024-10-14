using Hemuppgift_Arv_Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
 
    


    public abstract class Player 
    {

            public string userID {  get; set; }

            public Player(string name)
            { 
                userID = name;
                
            
            }
            public abstract int takePins(Board board);
            
       


    }

            



  

   public class HumanPlayer : Player
   {
        public HumanPlayer(string name) : base(name) { }

        public override int takePins(Board board)
        {
            bool userpin = false;
            

            while (!userpin)
            {
                Console.WriteLine($"{userID}, Ta en pinne eller två pinnar.");

                    



                try
                {
                    int pins = Convert.ToInt32(Console.ReadLine());


                    if (pins == 1 || pins == 2)
                    {
                        userpin = true;
                        return board.takePins(pins);

                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning.");
                       

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("VÄNLIGEN SKRIV HELTAL.");
                    
                }
                

            }
            return 0;
        }
   }
            public class ComputerPlayer : Player
            {
                private Random random = new Random();

                public ComputerPlayer(string userID) : base(userID) { }

                public override int takePins(Board board)
                {
                    int ComputerTake = random.Next(1,3);
                    Console.WriteLine($"{userID} tar {ComputerTake} pinnar.");
                    return board.takePins(ComputerTake);

                }


            }


        







    
}
