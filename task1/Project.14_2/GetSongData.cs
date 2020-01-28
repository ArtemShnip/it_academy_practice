using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project._14_2
{
    class GetSongData
    {
        public List<Song> songList = new List<Song>();

        public GetSongData()
        {
            new Song()
            {
                Title = "avtor1",
                Minutes = 3.17,
                Year = 2019
            };
            new Song()
            {
                Title = "avtor2",
                Minutes = 2.17,
                Year = 2013
            };
            new Song()
            {
                Title = "avtor3",
                Minutes = 4.17,
                Year = 2009
            };
        }
        public Song GetSong(string name)
        {
            return songList.FirstOrDefault(x =>x.Avtor == name);
        }
    }
}
