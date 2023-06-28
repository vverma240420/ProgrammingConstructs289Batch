using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EqualOrNot
    {
        public static void AcceptTwoInteger()
        {
            Console.WriteLine("Enter the first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b=Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Both numbers are equal");

            }
            else 
            {
                Console.WriteLine("Both numbers are not equal");
            }
            Console.ReadLine();
        }
    }
}
