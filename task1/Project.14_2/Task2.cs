using System;
using System.Collections.Generic;

namespace Project._14_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            List<Song> songList = new List<Song>();
            songList.Add(new Song()
            {
                Title = "Author1",
                Minutes = 3.17,
                Year = 2019
            });
            songList.Add(new Song()
            {
                Title = "Author2",
                Minutes = 2.17,
                Year = 2013
            });
            songList.Add(new Song()
            {
                Title = "Author3",
                Minutes = 4.17,
                Year = 2009
            });
            Console.WriteLine("enter title");
            string name = Console.ReadLine();
            GetSongData getSong = new GetSongData();
            getSong.GetSong(name, songList);
        }
    }
}
