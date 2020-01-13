namespace OOP.UnitTesting.StorageMaster.Tests.Structure
{
    using System;

    using NUnit.Framework;

    using OOP.UnitTesting.StorageMaster.Entities.Products;
    using OOP.UnitTesting.StorageMaster.Entities.Vehicles;

    [TestFixture]
    [Category("Structure Tests")]
    public class VehiclesTests
    {
        private Vehicle van = null;
        private Vehicle truck = null;
        private Vehicle semi = null;

        [SetUp]
        public void SetUp()
        {
            this.semi = new Semi();
            this.truck = new Truck();
            this.van = new Van();
        }

        [Test]
        public void Constructor_ShouldSetSemiCapacityToTen()
        {
            Assert.AreEqual(10, this.semi.Capacity);
        }

        [Test]
        public void Constructor_ShouldSetTruckCapacityToFive()
        {
            Assert.AreEqual(5, this.truck.Capacity);
        }

        [Test]
        public void Constructor_ShouldSetVanCapacityToTwo()
        {
            Assert.AreEqual(2, this.van.Capacity);
        }

        [Test]
        public void Constructor_ShouldInitializeTrunkCorrectly()
        {
            Assert.That(0, Is.EqualTo(this.semi.Trunk.Count));
            Assert.That(0, Is.EqualTo(this.truck.Trunk.Count));
            Assert.That(0, Is.EqualTo(this.van.Trunk.Count));
        }

        [Test]
        public void Load_ShouldAddtoTrunkSuccessfullyIfNotFull()
        {
            var product = new HardDrive(50);

            this.van.LoadProduct(product);

            Assert.AreEqual(1, this.van.Trunk.Count);
        }

        [Test]
        public void Load_ShouldThrowAnExceptionWhenTrunkIsFull()
        {
            var product = new Gpu(150);

            this.van.LoadProduct(product);
            this.van.LoadProduct(product);
            this.van.LoadProduct(product);

            Assert.Throws<InvalidOperationException>(() => this.van.LoadProduct(product));
        }

        [Test]
        public void Unload_ShouldReturnAndRemoveLastProductInTheTrunkIfNotEmpty()
        {
            var product = new Ram(25);

            this.van.LoadProduct(product);

            Assert.AreSame(product, this.van.Unload());
            Assert.AreEqual(0, this.van.Trunk.Count);
        }

        [Test]
        public void Unload_ShouldThrowExceptionIfTrunkIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.van.Unload());
        }

        [Test]
        [TestCase(3, typeof(Gpu))]
        [TestCase(2, typeof(HardDrive))]
        public void IsFull_ShouldReturnTrueIfTheTrunkIsFull(int numberOfProducts, Type type)
        {

            var product = (Product)Activator.CreateInstance(type, 150);

            for (int i = 0; i < numberOfProducts; i++)
            {
                this.van.LoadProduct(product);
            }

            Assert.That(this.van.IsFull, Is.True);
        }

        [Test]
        public void IsFull_ShouldReturnFalseIfTheTrunkIsNotFull()
        {
            var product = new Gpu(15);

            this.van.LoadProduct(product);

            Assert.That(this.van.IsFull, Is.False);
        }

        [Test]
        public void IsEmpty_ShouldReturnTrueIfTheTrunkIsEmpty()
        {
            Assert.That(this.van.IsEmpty, Is.True);
        }

        [Test]
        public void IsEmpty_ShouldReturnFalseIfTheTrunkIsNotEmpty()
        {
            var product = new Gpu(25);

            this.van.LoadProduct(product);

            Assert.That(this.van.IsEmpty, Is.False);
        }
    }
}
