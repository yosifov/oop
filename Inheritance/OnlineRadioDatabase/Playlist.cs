namespace OOP.Inheritance.OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Playlist
    {
        private List<Song> songs;
        private int hours;
        private int minutes;
        private int seconds;

        public Playlist()
        {
            this.songs = new List<Song>();
            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;
        }

        public void AddSong(Song song)
        {
            this.songs.Add(song);
            this.minutes += song.Minutes;
            this.seconds += song.Seconds;
            Console.WriteLine("Song added.");
        }

        public override string ToString()
        {
            this.CalculateLength();
            var sb = new StringBuilder();
            sb.AppendLine($"Songs added: {this.songs.Count}");
            sb.Append($"Playlist length: {this.hours}h {this.minutes}m {this.seconds}s");

            return sb.ToString();
        }

        private void CalculateLength()
        {
            var totalLengthInSeconds = this.seconds + (this.minutes * 60) + (this.hours * 60 * 60);
            var timespan = TimeSpan.FromSeconds(totalLengthInSeconds);
            this.hours = timespan.Hours;
            this.minutes = timespan.Minutes;
            this.seconds = timespan.Seconds;
        }
    }
}
