using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class Board
    {
        private int noPins;
        private int randomPins;

        public Board(int randomPins)
        {
            noPins = randomPins; 
            setUp(randomPins);
        }

        public void setUp(int pins) 
        {
            //noPins = pins; //Set game
            Random random = new Random();
            randomPins = random.Next(1, randomPins + 1);
        }



    

        public int takePins(int pins)
        {
          
                if (pins < 1 || pins > 2)
                {
                    Console.WriteLine("Du kan bara ta 1 eller 2 pinnar.");
                    return noPins;
                }

                if (noPins >= pins)
                {
                    noPins -= pins;
                    Console.WriteLine($"{pins} pinne är tagen.");
                }
            
        
                else if(pins < 0) 
                {
                    return noPins;
                    
                }
            

                return noPins;

            //Ta Pins

        }

        public int getNoPins() 
        {
            return noPins; // GameOver
        }




    }
}
