using System;

namespace practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            task1_EmptyArry();
        }

        public static void task1_EmptyArry()
        {
            Console.Write(" Enter length array - ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] arrayInt = new int[lenghtArray];
            string[] arrayString = new string[lenghtArray];
            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine("arrayString["+i+"] = \"" + arrayString[i]+"\"");
            }
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("arrayInt[" + i + "] = \"" + arrayInt[i] + "\"");
            }
            arrayInt[1] = arrayInt[1] + 4;
            Console.WriteLine("\narrayInt[1] + 4 = " + arrayInt[1]);
        }
    }
}
