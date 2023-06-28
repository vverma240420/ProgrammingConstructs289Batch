using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());   

            if(number % 2 == 0)                                        //dividing the number by 2 is equal to 0. If the remainder is 0, the number is even; otherwise, it is odd.
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
    }
}
