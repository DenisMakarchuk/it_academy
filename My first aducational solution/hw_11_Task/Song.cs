using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_11_Task
{
    enum Genre
    {
        Rock,
        Pop
    }

    class Song
    {
        string _nameSong;
        TimeSpan _time;
        string _nameAthor;
        DateTime _dateOfIssure;
        Genre _genre;

        public string NameSong { get { return _nameSong; } }
        public string Time { get { return _time.ToString(); } }
        public string AthorSong { get { return _nameAthor; } }
        public string DateOfIssure { get { return _dateOfIssure.ToLongDateString(); } }
        public Genre TheGenre { get { return _genre; } }

        public Song(string name, TimeSpan time, string athor, DateTime dateOfIssure, Genre genre)
        {
            _nameSong = name;
            _time = time;
            _nameAthor = athor;
            _dateOfIssure = dateOfIssure;
            _genre = genre;
        }
    }
}
