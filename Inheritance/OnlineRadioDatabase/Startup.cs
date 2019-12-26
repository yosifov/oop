namespace OOP.Inheritance.OnlineRadioDatabase
{
    using System;
    using System.Linq;
    using OOP.Inheritance.OnlineRadioDatabase.Exceptions;

    public class Startup : IService
    {
        public void Execute()
        {
            var playlist = new Playlist();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] songData = Console.ReadLine()
                        .Split(";");

                    if (songData.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    string songArtist = songData[0];
                    string songName = songData[1];
                    string songLength = songData[2];

                    if (songLength.Split(":").Length != 2)
                    {
                        throw new InvalidSongLengthException();
                    }

                    int songMinutes = int.Parse(songLength.Split(":").First());
                    int songSeconds = int.Parse(songLength.Split(":").Last());

                    var song = new Song(songArtist, songName, songMinutes, songSeconds);

                    playlist.AddSong(song);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(playlist);
        }
    }
}
