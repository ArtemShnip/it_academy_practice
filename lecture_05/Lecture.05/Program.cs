using System;


namespace Lecture._05
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time1 = System.DateTime.Now.TimeOfDay;
            int time = time1.Hours;
            Console.WriteLine(time );
            if (time > 9&& time < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            if (time > 12 && time < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            if (time > 15 && time < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else { Console.WriteLine("Good,night!"); }

        }
    }
}
