using System;

namespace DemoIfElseCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            double time; 
            time = Convert.ToInt32(Console.ReadLine());
            string tipeDayTime;

            if (time < 0 && time < 12)
            {
                Console.WriteLine("It's morning!");
                tipeDayTime = "morning";
            }

            else if (time > 12 && time < 17)
            {
                Console.WriteLine("It's afternoon");
                tipeDayTime = "afternoon";
            }

            else if (time > 17 && time < 23.59)
            {
                Console.WriteLine("It's dark outside");
                tipeDayTime = "night";
            }

            else 
            {
                Console.WriteLine("huh?");
                tipeDayTime = "huh";
            }


            DayTime dayTime = (DayTime)Enum.Parse(typeof(DayTime), tipeDayTime);

            switch (dayTime)
            {
                case DayTime.morning:
                    Console.WriteLine("Hey it's breakfast");
                    break;
                case DayTime.afternoon:
                    Console.WriteLine("Hey it's lunch");
                    break;
                case DayTime.night:
                    Console.WriteLine("Hey it's dinner");
                    break;
                case DayTime.dawn:
                    Console.WriteLine("It's too late, get back tomorrow");
                    break;
                default:
                    Console.WriteLine("huh?");
                    break;
            }
        }
    }
}