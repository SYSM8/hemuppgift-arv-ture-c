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
            switch(pins)
            {
                case 1:
                        if (noPins == 1 && noPins >= 1)
                        {
                            noPins -= 1;
                        Console.WriteLine("En pinne är tagen.");
                        }
                        
                    break;
                               
                    
                case 2:
                   
                     if (noPins == 2 && noPins >= 2)
                    {
                        noPins -= 2;
                        Console.WriteLine("Två pinnar är tagna.");
                    }
                     break;
                    
                        
                default:
                    Console.WriteLine("Felaktig inmatning.");
                 break;
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
