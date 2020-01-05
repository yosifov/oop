namespace OOP.UnitTesting.Database.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    [Category("Database")]
    public class DatabaseTests
    {
        private Database database;

        [Test]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { int.MinValue, int.MaxValue, 3, 4, 5 })]
        [TestCase(new int[] { 1, -2, 3, -4, 5, -6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void TestDatabaseWithValidNumbers(params int[] elements)
        {
            this.database = new Database(elements);

            Assert.AreEqual(elements.Length, database.Count);
        }

        [Test]
        public void TestEmptyDatabase()
        {
            this.database = new Database();

            Assert.That(database.Count == 0);
        }

        [Test]
        [TestCase(new int[] { 1, -2, 3, -4, 5, -6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void TestElementsProperty(params int[] elements)
        {
            this.database = new Database(elements);

            Assert.That(database.Elements.Length == 16);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void TestDatabaseWithMoreThanSixteenElements(params int[] elements)
        {
            Assert.Throws<InvalidOperationException>(() => new Database(elements), "Database with more than 16 elements should throw an exception");
        }

        [Test]
        [TestCase(new int[] { 2, 4, 6, 10})]
        public void TestAddNumberOnValidPosition(params int[] elements)
        {
            this.database = new Database(elements);

            database.Add(15);

            Assert.That(database.Count == 5);
            Assert.That(database.Elements[4] == 15);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void TestAddNumberOnInvalidPosition(params int[] elements)
        {
            this.database = new Database(elements);

            Assert.Throws<InvalidOperationException>(() => database.Add(18));
        }

        [Test]
        [TestCase(new int[] { 3, 5, 7, 9, 15 })]
        public void TestRemoveNumber(params int[] elements)
        {
            this.database = new Database(elements);

            database.Remove();

            Assert.That(database.Count == 4);
        }

        [Test]
        [TestCase(new int[] { 1 })]
        public void TestRemoveNumberFromEmptyDatabase(params int[] elements)
        {
            this.database = new Database(elements);

            database.Remove();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void TestFetchElements(params int[] elements)
        {
            this.database = new Database(elements);

            var fetchElements = database.Fetch();

            Assert.That(fetchElements.Length == 7);
            Assert.That(database.Elements[1] == fetchElements[1]);
        }

        [Test]
        public void AddPersonWithExistingUsernameShouldThrowAnException()
        {
            this.database = new Database();

            this.database.AddPerson(new Person("yosifov", 1001));

            Assert.Throws<InvalidOperationException>(() => this.database.AddPerson(new Person("yosifov", 1002)));
        }

        [Test]
        public void AddPersonWithExistingIdShouldThrowAnException()
        {
            this.database = new Database();

            this.database.AddPerson(new Person("yosifov", 1001));

            Assert.Throws<InvalidOperationException>(() => this.database.AddPerson(new Person("kamen", 1001)));
        }

        [Test]
        public void AddPersonWithValidData()
        {
            this.database = new Database();

            this.database.AddPerson(new Person("yosifov", 1001));
            this.database.AddPerson(new Person("kamen", 1002));

            Assert.AreEqual(2, this.database.People.Count);
        }

        [Test]
        public void RemovePersonThatExistShouldReturnTrue()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.That(this.database.RemovePerson(person));
        }

        [Test]
        public void RemovePersonThatNotExistShouldReturnFalse()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            Assert.That(this.database.RemovePerson(person) == false);
        }

        [Test]
        [TestCase("kamen")]
        [TestCase("Yosifov")]
        public void FindByUsernameWithNonExistingUserShouldThrowAnException(string username)
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(username));
        }

        [Test]
        public void FindByUsernameWithNullElementShouldThrowAnException()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void FindByUsernameWithCorrectDataShouldReturnPersonElement()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.AreEqual(person, this.database.FindByUsername("yosifov"));
        }

        [Test]
        public void FindByIdWithNonExistingIdShouldThrowAnException()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.Throws<InvalidOperationException>(() => this.database.FindById(1002));
        }

        [Test]
        public void FindByIdWithNegativeIdShouldThrowAnException()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1001));
        }

        [Test]
        public void FindByIdWithCorrectDataShouldReturnPersonElement()
        {
            this.database = new Database();

            var person = new Person("yosifov", 1001);

            this.database.AddPerson(person);

            Assert.AreEqual(person, this.database.FindById(1001));
        }
    }
}