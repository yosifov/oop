namespace OOP.UnitTesting.StorageMaster.Tests.Structure
{
    using System;
    using System.Reflection;

    using NUnit.Framework;

    using OOP.UnitTesting.StorageMaster.Entities.Products;

    [TestFixture]
    [Category("Structure Tests")]
    public class ProductsTests
    {
        [Test]
        [TestCase(typeof(Gpu), 150, 0.7)]
        [TestCase(typeof(HardDrive), 1, 1)]
        [TestCase(typeof(Ram), 0, 0.1)]
        [TestCase(typeof(SolidStateDrive), double.MaxValue, 0.2)]
        public void Constructor_ShouldSetPriceAndWeightCorrectly(Type type, double price, double weight)
        {
            var product = (Product)Activator.CreateInstance(type, price);

            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(weight, product.Weight);
        }

        [Test]
        [TestCase(typeof(Gpu), -150)]
        [TestCase(typeof(HardDrive), -1)]
        [TestCase(typeof(Ram), double.MinValue)]
        [TestCase(typeof(SolidStateDrive), -220)]
        public void Constructor_ShouldThrowExceptionWithNegativePrice(Type type, double price)
        {
            Product product = null;

            var ex = Assert.Throws<TargetInvocationException>(() => product = (Product)Activator.CreateInstance(type, price));

            Assert.That(ex.InnerException, Is.TypeOf<InvalidOperationException>());
        }
    }
}
