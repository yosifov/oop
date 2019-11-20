namespace OOP.Inheritance.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private int minSongSeconds;
        private int maxSongSeconds;

        public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds)
        {
            this.minSongSeconds = minSongSeconds;
            this.maxSongSeconds = maxSongSeconds;
        }

        public override string Message => $"Song seconds should be between {this.minSongSeconds} and {this.maxSongSeconds}.";
    }
}
