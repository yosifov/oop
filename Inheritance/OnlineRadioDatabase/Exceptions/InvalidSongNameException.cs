namespace OOP.Inheritance.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        private int minNameLength;
        private int maxNameLength;

        public InvalidSongNameException(int minNameLength, int maxNameLength)
        {
            this.minNameLength = minNameLength;
            this.maxNameLength = maxNameLength;
        }

        public override string Message => $"Song name should be between {this.minNameLength} and {this.maxNameLength} symbols.";
    }
}
