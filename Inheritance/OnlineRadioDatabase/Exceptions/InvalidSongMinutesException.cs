namespace OOP.Inheritance.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private int minSongMinutes;
        private int maxSongMinutes;

        public InvalidSongMinutesException(int minSongMinutes, int maxSongMinutes)
        {
            this.minSongMinutes = minSongMinutes;
            this.maxSongMinutes = maxSongMinutes;
        }

        public override string Message => $"Song minutes should be between {this.minSongMinutes} and {this.maxSongMinutes}.";
    }
}
