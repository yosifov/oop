namespace OOP.UnitTesting.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private const int DatabaseCapacity = 16;
        private int[] elements;
        private readonly List<Person> people;

        public Database()
        {
            this.Count = 0;
            this.elements = new int[DatabaseCapacity];
            this.people = new List<Person>();
        }

        public Database(params int[] elements)
        {
            this.Count = 0;
            this.Elements = elements;
            this.people = new List<Person>();
        }

        public int[] Elements
        {
            get
            {
                return this.elements.Take(this.Count).ToArray();
            }
            private set
            {
                if (value.Length > DatabaseCapacity || value.Length < 1)
                {
                    throw new InvalidOperationException($"Elements must be more than zero and less than {DatabaseCapacity}");
                }
                
                this.elements = new int[DatabaseCapacity];

                for (int i = 0; i < value.Length; i++)
                {
                    this.elements[i] = value[i];
                    this.Count++;
                }
            }
        }

        public IReadOnlyCollection<Person> People
        {
            get => this.people.AsReadOnly();
        }

        public int Count { get; private set; }

        public void Add(int number)
        {
            if (this.Count >= 16)
            {
                throw new InvalidOperationException("The database is full");
            }

            this.elements[this.Count] = number;
            this.Count++;
        }

        public void Remove()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The database is empty");
            }
            this.elements[Count - 1] = default;
            this.Count--;
        }

        public int[] Fetch()
        {
            return this.Elements;
        }

        public void AddPerson(Person person)
        {
            if (this.people.Any(x => x.Username == person.Username))
            {
                throw new InvalidOperationException("Person with this username already exist");
            }
            if (this.people.Any(x => x.Id == person.Id))
            {
                throw new InvalidOperationException("Person with this id already exist");
            }

            this.people.Add(person);
        }

        public bool RemovePerson(Person person)
        {
            return this.people.Remove(person);
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Username cannot be null");
            }
            if (!this.people.Any(x => x.Username == username))
            {
                throw new InvalidOperationException("No such username");
            }

            return this.people.FirstOrDefault(x => x.Username == username);
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("User id cannot be less than zero");
            }
            if (!this.people.Any(x => x.Id == id))
            {
                throw new InvalidOperationException("No such user");
            }

            return this.people.FirstOrDefault(x => x.Id == id);
        }
    }
}
