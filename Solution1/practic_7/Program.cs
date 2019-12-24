using System;

namespace practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            task1_EmptyArry();
            task2();
        }

        public static void task1_EmptyArry()
        {
            Console.Write(" Task 1\n Enter length array - ");
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
        public static void task2()
        {
            Console.Write("\n Press Enter go to task 2");
            Console.ReadLine();
            Console.WriteLine(" Task 2");
            object[] array2 = new object[3];
            array2[0] = 32;
            array2[1] = 'A';
            array2[2] = "Hello";

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("1)" + array2[i]);
            }                
            array2[0] = (int)array2[0] + 10;
            array2[2] = (string)array2[2] + ", gays!";
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("2)" + array2[i]);
            }
        }
    }
}
