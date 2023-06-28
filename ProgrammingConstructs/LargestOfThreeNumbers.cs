using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class LargestOfThreeNumbers
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = GetLargestNumber(number1, number2, number3);

            Console.WriteLine("The largest number is: " + largestNumber);

        }
        public static int GetLargestNumber(int number1, int number2, int number3)
        {
            int largest = number1;
            if (number2 > largest)
            {
                largest = number2;
            }
            else if (number3 > largest)
            {
                largest = number3;
            }
            return largest;
        }
        
    }
}
