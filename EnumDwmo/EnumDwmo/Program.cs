using System;

namespace EnumDemo
{
    internal class Program
    {
        public enum Days
        {
            Sunday,
            Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
         Saturday,
        }
        static void Main(string[] args)
        {
            Days today = Days.Saturday;
            Console.WriteLine("Today is: " + today);
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Its Sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Its Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Its Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Its Wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Its Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Its Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Its Saturday");
                    break;
                Default:
                    Console.WriteLine("Invalid Day");
                    break;

            }
            Console.ReadLine();
        }
    }
}
