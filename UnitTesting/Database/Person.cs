namespace OOP.UnitTesting.Database
{
    using System;

    public class Person
    {
        private long id;

        private string username;

        public Person(string username, long id)
        {
            this.Username = username;
            this.Id = id;
        }

        public string Username
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid {nameof(this.Username)}");
                }

                this.username = value;
            }
        }

        public long Id
        {
            get => this.id;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Invalid {nameof(this.Id)}");
                }

                this.id = value;
            }
        }

    }
}
