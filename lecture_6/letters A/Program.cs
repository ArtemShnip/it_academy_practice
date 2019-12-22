using System;

namespace letters_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < selection.Length; i++)
            {
                char letters = selection[i];
                char a = 'a';
                char aB = 'A';
                if (letters == a || letters == aB)
                {
                    count++;
                }                
            }
            Console.WriteLine(count);
        }
    }
}
