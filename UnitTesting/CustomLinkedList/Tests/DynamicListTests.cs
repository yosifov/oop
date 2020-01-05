namespace OOP.UnitTesting.CustomLinkedList.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    [Category("DynamicList")]
    public class DynamicListTests
    {
        DynamicList<int> dynamicListOfIntegers;

        [SetUp]
        public void SetUp()
        {
            this.dynamicListOfIntegers = new DynamicList<int>();
        }

        [Test]
        public void EmptyConstructorShouldInitializeCorrectDynamicList()
        {
            Assert.AreEqual(0, new DynamicList<int>().Count);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        public void AddMethodWithValidDataShouldAddElementCorrectly(int element)
        {
            this.dynamicListOfIntegers.Add(element);

            Assert.AreEqual(1, this.dynamicListOfIntegers.Count);
            Assert.AreEqual(element, this.dynamicListOfIntegers[0]);
        }

        [Test]
        [TestCase(1, -1)]
        [TestCase(1, 1)]
        public void GetElementByInvalidIndexShouldThrowAnException(int element, int index)
        {
            this.dynamicListOfIntegers.Add(element);

            int searchedElement;

            Assert.Throws<ArgumentOutOfRangeException>(() => searchedElement = this.dynamicListOfIntegers[index]);
        }

        [Test]
        public void GetElementWithCorrectIndexShouldReturnTheElement()
        {
            this.dynamicListOfIntegers.Add(1);
            this.dynamicListOfIntegers.Add(3);
            this.dynamicListOfIntegers.Add(5);
            this.dynamicListOfIntegers.Add(7);

            int searchedElement = this.dynamicListOfIntegers[2];

            Assert.AreEqual(5, searchedElement);
        }

        [Test]
        [TestCase(new int[] { 1, 3, 5, 7 }, -1)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 4)]
        public void RemoveAtMethodShouldThrowAnExceptionWithInvalidData(int[] elementsToAdd, int index)
        {
            foreach (var element in elementsToAdd)
            {
                this.dynamicListOfIntegers.Add(element);
            }

            Assert.Throws<ArgumentOutOfRangeException>(() => this.dynamicListOfIntegers.RemoveAt(index));
        }

        [Test]
        [TestCase(new int[] { 1, 3, 5, 7 }, 0)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 1)]
        [TestCase(new int[] { 1, 3, 5, 7 }, 3)]
        [TestCase(new int[] { 1 }, 0)]
        public void RemoveAtMethodShouldRemoveElementCorrectlyWithValidData(int[] elementsToAdd, int index)
        {
            foreach (var element in elementsToAdd)
            {
                this.dynamicListOfIntegers.Add(element);
            }

            int initialCount = this.dynamicListOfIntegers.Count;
            int elementToRemove = this.dynamicListOfIntegers[index];

            int removedElement = this.dynamicListOfIntegers.RemoveAt(index);

            Assert.AreEqual(initialCount - 1, this.dynamicListOfIntegers.Count);
            Assert.AreEqual(elementToRemove, removedElement);
        }
    }
}
