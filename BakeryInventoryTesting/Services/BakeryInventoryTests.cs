using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.Models;
using WebApiProject.Services;
namespace BakeryInventoryTesting.Services
{
    [TestFixture]
    public class BakeryInventoryTests
    {
        private BakeryInventory _inventory;
        private BakeryItem _testItem;

        [SetUp]
        public void Setup()
        {
            _inventory = new BakeryInventory();
            _testItem = new BakeryItem
            {
                Name = "Baguette",
                Price = 3.00m,
                Quantity = 5,
                ExpirationDate = DateTime.Now.AddDays(3)
            };
        }

        [Test]
        public void AddItem_ValidItem_ItemAddedSuccessfully()
        {
            // Act
            _inventory.AddItem(_testItem);

            // Assert
            Assert.That(_inventory.GetItemCount(), Is.EqualTo(1));
            Assert.That(_inventory.GetTotalValue(), Is.EqualTo(15.00m));
        }

        [Test]
        public void AddItem_NullItem_ThrowsArgumentNullException()
        {
            // Act & Assert
            var ex = Assert.Throws<ArgumentNullException>(() => _inventory.AddItem(null));
            Assert.That(ex.ParamName, Is.EqualTo("item"));
        }

        [Test]
        public void AddItem_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            var invalidItem = new BakeryItem { Name = "" };

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _inventory.AddItem(invalidItem));
            Assert.That(ex.Message, Does.Contain("Item name cannot be empty"));
        }

        [Test]
        public void AddItem_NegativePrice_ThrowsArgumentException()
        {
            // Arrange
            var invalidItem = new BakeryItem
            {
                Name = "Invalid Item",
                Price = -5.00m
            };

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => _inventory.AddItem(invalidItem));
            Assert.That(ex.Message, Does.Contain("Price must be greater than 0"));
        }

        [Test]
        public void RemoveItem_ExistingItem_ReturnsTrueAndRemovesItem()
        {
            // Arrange
            _inventory.AddItem(_testItem);
            var initialCount = _inventory.GetItemCount();

            // Act
            var result = _inventory.RemoveItem("Baguette");

            // Assert
            Assert.That(result, Is.True);
            Assert.That(_inventory.GetItemCount(), Is.EqualTo(initialCount - 1));
        }

        [Test]
        public void RemoveItem_NonExistingItem_ReturnsFalse()
        {
            // Act
            var result = _inventory.RemoveItem("NonExisting");

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void RemoveItem_EmptyName_ReturnsFalse()
        {
            // Act
            var result = _inventory.RemoveItem("");

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void RemoveItems_MultipleItemsWithSameName_RemovesAll()
        {
            // Arrange
            var item1 = new BakeryItem { Name = "Croissant", Price = 2.50m, Quantity = 3 };
            var item2 = new BakeryItem { Name = "Croissant", Price = 2.75m, Quantity = 2 };

            _inventory.AddItem(item1);
            _inventory.AddItem(item2);

            // Act
            var result = _inventory.RemoveItems("Croissant");

            // Assert
            Assert.That(result, Is.True);
            Assert.That(_inventory.GetItemCount(), Is.EqualTo(0));
        }

        [Test]
        public void GetTotalValue_WithMultipleItems_ReturnsCorrectSum()
        {
            // Arrange
            var item1 = new BakeryItem { Name = "Item1", Price = 2.00m, Quantity = 3 };
            var item2 = new BakeryItem { Name = "Item2", Price = 1.50m, Quantity = 4 };

            _inventory.AddItem(item1);
            _inventory.AddItem(item2);

            // Act
            var total = _inventory.GetTotalValue();

            // Assert
            var expectedTotal = (2.00m * 3) + (1.50m * 4); // 6 + 6 = 12
            Assert.That(total, Is.EqualTo(12.00m));
        }

        [Test]
        public void GetTotalValue_EmptyInventory_ReturnsZero()
        {
            // Act
            var total = _inventory.GetTotalValue();

            // Assert
            Assert.That(total, Is.EqualTo(0m));
        }

        [Test]
        public void GetExpiredItems_ReturnsOnlyExpiredItems()
        {
            // Arrange
            var expiredItem = new BakeryItem
            {
                Name = "Expired",
                ExpirationDate = DateTime.Now.AddDays(-1)
            };
            var freshItem = new BakeryItem
            {
                Name = "Fresh",
                ExpirationDate = DateTime.Now.AddDays(1)
            };

            _inventory.AddItem(expiredItem);
            _inventory.AddItem(freshItem);

            // Act
            var expiredItems = _inventory.GetExpiredItems();

            // Assert
            Assert.That(expiredItems.Count, Is.EqualTo(1));
            Assert.That(expiredItems[0].Name, Is.EqualTo("Expired"));
        }

        [Test]
        public void GetItem_ExistingItem_ReturnsCorrectItem()
        {
            // Arrange
            _inventory.AddItem(_testItem);

            // Act
            var foundItem = _inventory.GetItem("Baguette");

            // Assert
            Assert.That(foundItem, Is.Not.Null);
            Assert.That(foundItem.Name, Is.EqualTo("Baguette"));
            Assert.That(foundItem.Price, Is.EqualTo(3.00m));
        }

        [Test]
        public void GetItem_NonExistingItem_ReturnsNull()
        {
            // Act
            var foundItem = _inventory.GetItem("NonExisting");

            // Assert
            Assert.That(foundItem, Is.Null);
        }
    }
}
