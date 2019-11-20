namespace OOP.Inheritance.OnlineRadioDatabase.Validations
{
    using OOP.Inheritance.OnlineRadioDatabase.Exceptions;

    public class ArtistNameValidation : ISongValidation
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 20;
        private string name;

        public ArtistNameValidation(string name)
        {
            this.name = name;
        }

        public void Validate()
        {
            if (this.name.Length < MinNameLength || this.name.Length > MaxNameLength)
            {
                throw new InvalidArtistNameException(MinNameLength, MaxNameLength);
            }
        }
    }
}
