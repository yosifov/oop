namespace OOP.Inheritance.OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private int minNameLength;
        private int maxNameLength;

        public InvalidArtistNameException(int minNameLength, int maxNameLength)
        {
            this.minNameLength = minNameLength;
            this.maxNameLength = maxNameLength;
        }

        public override string Message => $"Artist name should be between {this.minNameLength} and {this.maxNameLength} symbols.";
    }
}
