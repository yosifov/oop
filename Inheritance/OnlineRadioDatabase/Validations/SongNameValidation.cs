namespace OOP.Inheritance.OnlineRadioDatabase.Validations
{
    using OOP.Inheritance.OnlineRadioDatabase.Exceptions;

    public class SongNameValidation : ISongValidation
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 30;
        private string name;

        public SongNameValidation(string name)
        {
            this.name = name;
        }

        public void Validate()
        {
            if (this.name.Length < MinNameLength || this.name.Length > MaxNameLength)
            {
                throw new InvalidSongNameException(MinNameLength, MaxNameLength);
            }
        }
    }
}
