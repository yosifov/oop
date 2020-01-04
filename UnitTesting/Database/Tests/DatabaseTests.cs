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
    }
}