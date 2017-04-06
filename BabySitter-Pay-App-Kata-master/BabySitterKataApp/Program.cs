using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKataApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Baby-Sitter Time-Tracker and Pay Calculator\n");
            Console.WriteLine("Please enter the time details.");
            Console.WriteLine("\nWhat time did you start?");
            int startTime = TimeTracker();

        #region BedTime Logic
        // goto statement to ensure a valid response for bedtime
        BED:
            Console.Write("Was there a bed-time? Enter (y / n) : ");
            int bedtime = 12;
            var isThereABedtime = Console.ReadLine().ToLower();

            if (isThereABedtime == "y")
            {
                bedtime = TimeTracker();
            }
            else if (isThereABedtime == "n")
            {
                bedtime = 12;
            }
            else
            {
                Console.WriteLine("please enter either 'y' for yes, or 'n' for no.\n");
                goto BED;
            }
            Console.Clear();
            #endregion

            Console.WriteLine("\nWhat was the ending time?");
            var endTime = TimeTracker();

            #region Logic
            //Total time spent working
            int totalTime = endTime - startTime;
            int timeTilBedtime = bedtime - startTime;

            Console.WriteLine("Total Time = {0} Hours \n:", totalTime);

            //pay calculations
            int money = WageCalc(totalTime, startTime, timeTilBedtime);
            Console.WriteLine("Total pay = ${0} ", money);
            Console.ReadKey();
            #endregion

        }

        //method to track money
        public static int WageCalc(int totalHours, int startTime, int timeTilBedtime)
        {
            int money = 0;
            int midnite = 7 - startTime;

            for (int i = 0; i < totalHours;)
            {
                if (i >= timeTilBedtime && i < midnite)
                {
                    money += 8;
                }
                else if (i >= midnite)
                {
                    money += 16;
                }
                else
                {
                    money += 12;
                }

                i++;
            }

            return money;
        }

        // method to track time
        public static int TimeTracker()
        {
            Console.WriteLine("\nEnter the corresponding number: \n5pm = 0 \n6pm = 1 \n7pm = 2 \n8pm = 3 \n9pm = 4 \n10pm = 5 \n11pm = 6 \n12pm = 7 \n1am = 8 \n2am = 9 \n3am = 10 \n4am = 11 \n");
            Console.Write("Respnose: "); int time = Convert.ToInt32(Console.ReadLine());

        Start:

            switch (time)
            {
                case 0:
                    time = 0;
                    break;

                case 1:
                    time = 1;
                    break;
                case 2:
                    time = 2;
                    break;
                case 3:
                    time = 3;
                    break;
                case 4:
                    time = 4;
                    break;

                case 5:
                    time = 5;
                    break;
                case 6:
                    time = 6;
                    break;
                case 7:
                    time = 7;
                    break;
                case 8:
                    time = 8;
                    break;
                case 9:
                    time = 9;
                    break;
                case 10:
                    time = 10;
                    break;
                case 11:
                    time = 11;
                    break;

                default:
                    Console.WriteLine("You did not enter a valid input. Please try again!\n");
                    goto Start;
                    break;
            }
            return time;

        }

    }
}
