namespace OOP.Interfaces.Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            Validator.ValidateUrl(url);

            return $"Browsing... {url}";
        }

        public string Call(string number)
        {
            Validator.ValidatePhoneNumber(number);

            return $"Calling... {number}";
        }
    }
}
