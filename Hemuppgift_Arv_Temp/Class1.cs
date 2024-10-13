using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class Board
    {
        private int noPins;

        public Board(int startpins)
        {
            noPins = startpins; 

        }

        public void setUp(int pins) 
        {
            noPins = pins; //Set game
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
                Console.WriteLine($"{pins} pinnar är tagen.");
            }
            else
            {
                Console.WriteLine("Det finns inte tillräckligt många pinnar kvar.");
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
