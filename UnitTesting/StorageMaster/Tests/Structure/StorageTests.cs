namespace OOP.UnitTesting.StorageMaster.Tests.Structure
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    using OOP.UnitTesting.StorageMaster.Entities.Storage;
    using OOP.UnitTesting.StorageMaster.Entities.Vehicles;

    [TestFixture]
    [Category("Structure Tests")]
    public class StorageTests
    {
        private Storage storage;

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse")]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center")]
        [TestCase(typeof(Warehouse), "Test Warehouse")]
        public void Constructor_ShouldSetStorageNameSuccessfully(
            Type storageType,
            string storageName)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            StringAssert.AreEqualIgnoringCase(storageName, this.storage.Name);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 1)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 2)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 10)]
        public void Constructor_ShouldSetStorageCapacitySuccessfully(
            Type storageType,
            string storageName,
            int storageCapacity)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.AreEqual(storageCapacity, this.storage.Capacity);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 2)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 5)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 10)]
        public void Constructor_ShouldSetStorageGarageSlotsSuccessfully(
            Type storageType, 
            string storageName,
            int storageGarageSlots)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.AreEqual(storageGarageSlots, this.storage.GarageSlots);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 2, typeof(Truck))]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 5, typeof(Van))]
        [TestCase(typeof(Warehouse), "Test Warehouse", 10, typeof(Semi))]
        public void Constructor_ShouldInitializeStorageGarageSuccessfully(
            Type storageType, 
            string storageName, 
            int storageGarageSlots, 
            Type vehicleType)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.AreEqual(storageGarageSlots, this.storage.Garage.Count);
            Assert.That(this.storage.Garage.Where(v => v != null).All(v => v.GetType() == vehicleType));
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse")]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center")]
        [TestCase(typeof(Warehouse), "Test Warehouse")]
        public void Cosntructor_ShouldInitializeStorageProducts(
            Type storageType,
            string storageName)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.AreEqual(0, this.storage.Products.Count);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 0)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 1)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 2)]
        public void GetVehicle_ShouldReturnVehicleSuccessfully(
            Type storageType,
            string storageName,
            int storageGarageSlot)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.That(this.storage.GetVehicle(storageGarageSlot), Is.Not.Null);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 2)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 5)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 10)]
        public void GetVehicle_ShouldThrowExceptionWithInvalidGarageSlot(
            Type storageType,
            string storageName,
            int storageGarageSlot)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            var ex = Assert.Throws<InvalidOperationException>(() => this.storage.GetVehicle(storageGarageSlot));
            Assert.AreEqual("Invalid garage slot!", ex.Message);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 1)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 4)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 9)]
        public void GetVehicle_ShouldThrowExceptionWhenAccessEmptyGarageSlot(
            Type storageType,
            string storageName,
            int storageGarageSlot)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            var ex = Assert.Throws<InvalidOperationException>(() => this.storage.GetVehicle(storageGarageSlot));
            Assert.AreEqual("No vehicle in this garage slot!", ex.Message);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse", 0, "Automated Warehouse To Move", 1)]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center", 1, "Distribution Center To Move", 3)]
        [TestCase(typeof(Warehouse), "Test Warehouse", 2, "Warehouse To Move", 3)]
        public void SendVehicleTo_ShouldReturnMovedSlotSuccessfully(
            Type storageType,
            string storageName,
            int storageGarageSlot,
            string storageToMoveName,
            int freeSlotToMove)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);
            var storageToMove = (Storage)Activator.CreateInstance(storageType, storageToMoveName);

            int actualResult = this.storage.SendVehicleTo(storageGarageSlot, storageToMove);

            Assert.Throws<InvalidOperationException>(() => this.storage.GetVehicle(storageGarageSlot));
            Assert.AreEqual(freeSlotToMove, actualResult);
        }

        [Test]
        public void SendVehicle_ShouldThrowExceptionForAutomatedWarehouseWhenNotEmptySlotsAvailableAtDestinationStorage()
        {
            this.storage = new AutomatedWarehouse("Test Automated Warehouse");

            var secondStorage = new AutomatedWarehouse("Second Automated Warehouse");
            var thirdStorage = new AutomatedWarehouse("Third Automated Warehouse");

            secondStorage.SendVehicleTo(0, this.storage);

            Assert.Throws<InvalidOperationException>(() => thirdStorage.SendVehicleTo(0, this.storage));
        }

        [Test]
        public void SendVehicle_ShouldThrowExceptionForDistributionCenterWhenNotEmptySlotsAvailableAtDestinationStorage()
        {
            this.storage = new DistributionCenter("Test Distribution Center");

            var secondStorage = new DistributionCenter("Second Distribution Center");
            var thirdStorage = new DistributionCenter("Third Distribution Center");

            secondStorage.SendVehicleTo(0, this.storage);
            secondStorage.SendVehicleTo(1, this.storage);

            Assert.Throws<InvalidOperationException>(() => thirdStorage.SendVehicleTo(0, this.storage));
        }

        [Test]
        public void SendVehicle_ShouldThrowExceptionForWarehouseWhenNotEmptySlotsAvailableAtDestinationStorage()
        {
            this.storage = new Warehouse("Test Warehouse");

            var secondStorage = new Warehouse("Second Warehouse");
            var thirdStorage = new Warehouse("Third Warehouse");
            var fourthStorage = new Warehouse("Fourth Warehouse");

            secondStorage.SendVehicleTo(0, this.storage);
            secondStorage.SendVehicleTo(1, this.storage);
            secondStorage.SendVehicleTo(2, this.storage);
            thirdStorage.SendVehicleTo(0, this.storage);
            thirdStorage.SendVehicleTo(1, this.storage);
            thirdStorage.SendVehicleTo(2, this.storage);
            fourthStorage.SendVehicleTo(0, this.storage);

            Assert.Throws<InvalidOperationException>(() => fourthStorage.SendVehicleTo(1, this.storage));
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse")]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center")]
        [TestCase(typeof(Warehouse), "Test Warehouse")]
        public void UnloadVehicle_ShouldReturnUnloadedProdutcsCountSuccessfully(
            Type storageType,
            string storageName)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            int actualResult = this.storage.UnloadVehicle(0);

            Assert.AreEqual(0, actualResult);
        }

        [Test]
        [TestCase(typeof(AutomatedWarehouse), "Test Automated Warehouse")]
        [TestCase(typeof(DistributionCenter), "Test Distribution Center")]
        [TestCase(typeof(Warehouse), "Test Warehouse")]
        public void IsFull_ShouldReturnFalseIfThereIsCapacityLeft(
            Type storageType,
            string storageName)
        {
            this.storage = (Storage)Activator.CreateInstance(storageType, storageName);

            Assert.That(this.storage.IsFull, Is.False);
        }
    }
}
