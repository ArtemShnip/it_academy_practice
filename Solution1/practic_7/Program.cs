using System;

namespace practic_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void task_1(string[] args)
        {
            Console.WriteLine("enter num");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array1 = new int[lenghtArray];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
        static void task_2(string[] args)
        {
            object[] array2 = new object[3];
            array2[1] = 32;
            array2[2] = 'A';
            array2[3] = "Hello";

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("1)" + array2[i]);
            }
            Console.WriteLine("2)" + array2[1]+10 + " " + array2[3]+",guys!");            
        }
        static void task_3(string[] args)
        {
            int[] array = new int[13];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= array[i] = new Random().Next();
            }

        }
    }
}
