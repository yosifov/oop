namespace OOP.Inheritance.OnlineRadioDatabase.Validations
{
    using OOP.Inheritance.OnlineRadioDatabase.Exceptions;

    public class SongSecondsValidation : ISongValidation
    {
        private const int MinSongSeconds = 0;
        private const int MaxSongSeconds = 59;
        private int seconds;

        public SongSecondsValidation(int seconds)
        {
            this.seconds = seconds;
        }

        public void Validate()
        {
            if (this.seconds < MinSongSeconds || this.seconds > MaxSongSeconds)
            {
                throw new InvalidSongSecondsException(MinSongSeconds, MaxSongSeconds);
            }
        }
    }
}
