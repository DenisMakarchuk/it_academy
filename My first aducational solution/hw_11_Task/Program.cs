using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var song1 = IniAndGetAnonimous.Ini();

            Console.WriteLine();

            Console.WriteLine($"The title of the song: {song1.NameSong}");
            Console.WriteLine($"The duration of the song: {song1.Time}");
            Console.WriteLine($"The athor of the song: {song1.AthorSong}");
            Console.WriteLine($"The date of issure of the song: {song1.DateOfIssure}");
            Console.WriteLine($"The genre of the song: {song1.TheGenre}");

            Console.WriteLine();

            object anonimous = IniAndGetAnonimous.GetAnonimousTipe(song1);
            var typed = Cast(anonimous, new { Title = string.Empty, Minutes = string.Empty, AlbumYear = string.Empty });

            Console.WriteLine("Title={0}, Minutes={1}, AlbumYear={2}", typed.Title, typed.Minutes, typed.AlbumYear);

            Console.WriteLine(JsonConvert.SerializeObject(new { anonimous }));

            Console.Read();
        }
        static T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }
    }
}
