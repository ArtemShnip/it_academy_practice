using System;

namespace Lecture._05
{
    class Program
    {
        static void Main(string[] args)
        {

            System.DateTime date = new System.DateTime();


            int hours = 0;

            if (hours > 9&&hours <12)
            {
                Console.WriteLine("Good morning, guys");
            }
            if (hours > 12 && hours < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            if (hours > 15 && hours < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
        }
    }
}
