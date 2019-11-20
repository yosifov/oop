namespace OOP.Inheritance.OnlineRadioDatabase.Validations
{
    using OOP.Inheritance.OnlineRadioDatabase.Exceptions;

    public class SongMinutesValidation : ISongValidation
    {
        private const int MinSongMinutes = 0;
        private const int MaxSongMinutes = 14;
        private int minutes;

        public SongMinutesValidation(int minutes)
        {
            this.minutes = minutes;
        }

        public void Validate()
        {
            if (this.minutes < MinSongMinutes || this.minutes > MaxSongMinutes)
            {
                throw new InvalidSongMinutesException(MinSongMinutes, MaxSongMinutes);
            }
        }
    }
}
