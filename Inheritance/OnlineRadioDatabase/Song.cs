namespace OOP.Inheritance.OnlineRadioDatabase
{
    using OOP.Inheritance.OnlineRadioDatabase.Validations;

    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Artist
        {
            get => this.artist;
            private set
            {
                this.ValidateSong(new ArtistNameValidation(value));
                this.artist = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.ValidateSong(new SongNameValidation(value));
                this.name = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            private set
            {
                this.ValidateSong(new SongMinutesValidation(value));
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            private set
            {
                this.ValidateSong(new SongSecondsValidation(value));
                this.seconds = value;
            }
        }

        private void ValidateSong(ISongValidation validation)
        {
            validation.Validate();
        }
    }
}
