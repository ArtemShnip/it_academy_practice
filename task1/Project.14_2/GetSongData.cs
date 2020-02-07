using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project._14_2
{
    class GetSongData
    {

        public void GetSong(string name, List<Song> songs)
        {
            var selectedSong = from Song in songs
                                where Song.Title == name
                                select Song;
            foreach (Song song in selectedSong)
                Console.WriteLine($"Title:{song.Title}, Minutes:{song.Minutes}, Year{song.Year}");
        }
    }
}
