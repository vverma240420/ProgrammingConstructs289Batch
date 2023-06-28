using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class FlipCoin
    {
        public static void HeadAndTails()
        {
            int headsCount = 0;
            int tailsCount = 0;

            Random random= new Random();
            while(headsCount <20 && tailsCount <20)
            {
                int result = random.Next(0, 2);  // o is represent tails and 1 is represent head

                if(result ==0) 
                {
                    tailsCount++;
                    Console.WriteLine("Tails");

                }
                else 
                {
                    headsCount++;
                    Console.WriteLine("Head");
                }
            }
            if(headsCount ==20)
            {
                Console.WriteLine("Head Wins");

            }
            else
            {
                Console.WriteLine("Tails Wins");
            }
            Console.ReadLine();
        }
        
    }
    
}
