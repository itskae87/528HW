using System;

namespace methodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's go on a date!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. We can watch a movie, 2. Go to an amusement park, 3. Go for a long drive");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                case "movie":
                    romcom();
                    break;

                case "2":
                case "amusement park":
                    roller(11);
                    break;

                case "3":
                case "drive":
                    string latenight = drives(8);
                    Console.WriteLine(latenight);
                    break;

                default:
                    Console.WriteLine("hrmmm no suggestion, will have to wait for my next availability");
                    break;
            }

        }
        private static void romcom()
        {
            Console.WriteLine("I hope you like romantic comedy");
            Console.WriteLine("'How to be single' is always a good laugh");
        }

        private static void roller(int ride)
        {
            Console.WriteLine("I love adrenaline rush");
            Console.WriteLine("Lets go for {0} rides", ride);
        }

        private static string drives(int way)
        {
            Console.WriteLine("Lets go for a drive along the west coast!");
            for (int i = 0; i < way; i++)
            {
                roller(i);
            }
            return "lets go at it again";
        }

    }
}
