using System;
using System.Collections.Generic;

namespace Project._14_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            GetSongData getSongData = new GetSongData();
            string val = Console.ReadLine();
            var name = getSongData.GetSong(val);
            
            


        }
    }
}
