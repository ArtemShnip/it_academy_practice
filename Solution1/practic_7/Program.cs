using System;

namespace practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            task1_EmptyArry();
            task2();
            task3();
            task4();
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
            arrayInt[1] = arrayInt[0] + 4;
            Console.WriteLine("\narrayInt[0] + 4 = " + arrayInt[1]);
        }
        public static void task2()
        {
            Console.Write("\n Press Enter go to task 2");
            Console.ReadLine();
            Console.WriteLine(" Task 2");
            object[] array = new object[3];
            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("1)" + array[i]);
            }                
            array[0] = (int)array[0] + 10;
            array[2] = (string)array[2] + ", gays!";
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("2)" + array[i]);
            }
        }
        public static void task3()
        {
            Console.Write("\n Press Enter go to task 3");
            Console.ReadLine();
            Console.WriteLine(" Task 3");
            int[] array = new int[13];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + " - " + array[i]);
                if (array[i]>=max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("max - " + max);
        }
        public static void task4()
        {
            Console.Write("\n Press Enter go to task 4");
            Console.ReadLine();
            Console.WriteLine(" Task 4");
            short num = 5;
            object obj = num;
            short num1 = (short)obj;
            sbyte sb = (sbyte)num1;
            Console.WriteLine(sb.GetType());
        }
    }
}
