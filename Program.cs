/*
 * Daily Temps
 * Pawelski
 * 1/11/2022
 * Read the code and run the program a few times to see what it does. 
 * Once you are familiar with the program, modify the program so it
 * accomplishes the goal described on the activity sheet. Finally,
 * answer any questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTemps
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp, total = 0;
            do
            {
                Console.Write("Enter a temperature between -20F and " +
                    "130F, or -100 to quit >> ");
                temp = Convert.ToDouble(Console.ReadLine());
                if (-20 <= temp && temp <= 130)
                {
                    total += temp;
                }
                else if (temp != -100)
                {
                    Console.WriteLine("Invalid temperature!");
                }
            } while (temp != -100);
            Console.WriteLine("Total: " + total);
        }
    }
}
