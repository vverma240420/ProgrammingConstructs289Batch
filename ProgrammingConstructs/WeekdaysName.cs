﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class WeekdaysName
    {
        public static void WeekdayName()
        {
            Console.Write("Enter a weekday number (1-7): ");
            int weekdayNumber = Convert.ToInt32(Console.ReadLine());

            string weekdayName = GetWeekdayName(weekdayNumber);

            Console.WriteLine("The weekday name is: " + weekdayName);

        }
        public static string GetWeekdayName(int weekdayNumber)
        {
            string weekdayName;

            switch (weekdayNumber)
            {
                case 1:
                    weekdayName = "Monday";
                    break;
                case 2:
                    weekdayName = "Tuesday";
                    break;
                case 3:
                    weekdayName = "Wednesday";
                    break;
                case 4:
                    weekdayName = "Thursday";
                    break;
                case 5:
                    weekdayName = "Friday";
                    break;
                case 6:
                    weekdayName = "Saturday";
                    break;
                case 7:
                    weekdayName = "Sunday";
                    break;
                default:
                    weekdayName = "Invalid weekday number";
                    break;
            }

            return weekdayName;
        }
        
    }
}
