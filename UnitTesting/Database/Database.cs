namespace OOP.UnitTesting.Database
{
    using System;
    using System.Linq;

    public class Database
    {
        private const int DatabaseCapacity = 16;
        private int[] elements;

        public Database()
        {
            this.Count = 0;
            this.elements = new int[DatabaseCapacity];
        }

        public Database(params int[] elements)
        {
            this.Count = 0;
            this.Elements = elements;
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
    }
}
