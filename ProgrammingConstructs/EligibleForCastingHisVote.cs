using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class EligibleForCastingHisVote
    {
        public static void CastingHisVote()
        {
            Console.WriteLine("Enter the age :");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are eligible to cast your vote.");

            }
            else 
            {
                Console.WriteLine("You are not eligible to cast your vote.");
            }
            Console.ReadLine();
        }
    }
}
