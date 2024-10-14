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
        private Random random;


        public Board(int minpin, int maxpin)
        {
            random = new Random();
            noPins = random.Next(minpin, maxpin);
            


        }
       

        public void setUp(int pins) 
        {
            noPins = pins;
            
            
        }



    

        public int takePins(int pins)
        {

            

                if (noPins >= pins)

                {

                    noPins -= pins;
                    //Console.WriteLine($"{pins} pinne är tagen.");
                    

                }


                else if (pins < 0)

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
