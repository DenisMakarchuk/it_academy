using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_11_Task
{
    class IniAndGetAnonimous
    {
        public static Song Ini()
        {
            string nameSong, nameAthor;
            TimeSpan timeDuration = new TimeSpan();
            DateTime date = new DateTime();
            Genre genre = new Genre();

            do
            {
                Console.WriteLine("Enter title of the song:");
                nameSong = Console.ReadLine();
            }
            while (IsEmpty.LettersTrue(nameSong) != true);

            do
            {
                Console.WriteLine("Enter name of athor the song:");
                nameAthor = Console.ReadLine();
            }
            while (IsEmpty.LettersTrue(nameAthor) != true);

            Console.WriteLine("Enter the song duration 'mm.ss':");
            string time = Console.ReadLine();
            string[] piesesTime = time.Split('.');
            timeDuration = new TimeSpan(0, Convert.ToInt32(piesesTime[0]), Convert.ToInt32(piesesTime[1]));

            do
            {
                try
                {
                    Console.WriteLine("Enter the date of issure the song 'dd.mm.yyyy':");
                    date = Convert.ToDateTime(Console.ReadLine());
                }
                catch (System.FormatException) { }
                if (date != new DateTime())
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine("Enter the genre, Roch or Pop:");
            string sGenre = Console.ReadLine();
            switch (sGenre)
            {
                case "Rock":
                    genre = Genre.Rock;
                    break;
                case "Pop":
                    genre = Genre.Pop;
                    break;
                default:
                    Console.WriteLine("Entered invilid genre. Genre = Rock");
                    break;
            }

            Song song = new Song(nameSong, timeDuration, nameAthor, date, genre);

            return song;
        }
        public static object GetAnonimousTipe(Song song1)
        {
            return new
            {
                Title = song1.NameSong,
                Minutes = song1.Time,
                AlbumYear = song1.DateOfIssure
            };
        }
    }
}
