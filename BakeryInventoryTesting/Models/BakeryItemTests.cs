using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace BakeryInventoryTesting.Models
{
    [TestFixture]
    public class BakeryItemTests
    {
        [Test]
        public void BakeryItem_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            var itemName = "Croissant";
            var price = 2.50m;
            var quantity = 10;
            var expirationDate = DateTime.Now.AddDays(7);

            // Act
            var item = new BakeryItem
            {
                Name = itemName,
                Price = price,
                Quantity = quantity,
                ExpirationDate = expirationDate
            };

            // Assert
            Assert.That(item.Name, Is.EqualTo(itemName));
            Assert.That(item.Price, Is.EqualTo(price));
            Assert.That(item.Quantity, Is.EqualTo(quantity));
            Assert.That(item.ExpirationDate, Is.EqualTo(expirationDate));
        }

        [Test]
        public void IsExpired_WhenDateIsInFuture_ReturnsFalse()
        {
            // Arrange
            var item = new BakeryItem
            {
                ExpirationDate = DateTime.Now.AddDays(1)
            };

            // Act
            var result = item.IsExpired();

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsExpired_WhenDateIsInPast_ReturnsTrue()
        {
            // Arrange
            var item = new BakeryItem
            {
                ExpirationDate = DateTime.Now.AddDays(-1)
            };

            // Act
            var result = item.IsExpired();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsExpired_WhenDateIsToday_ReturnsFalse()
        {
            // Arrange
            var item = new BakeryItem
            {
                ExpirationDate = DateTime.Now.Date
            };

            // Act
            var result = item.IsExpired();

            // Assert
            Assert.That(result, Is.False, "Item should not be expired if expiration date is today");
        }

        [Test]
        public void GetTotalValue_CalculatesCorrectly()
        {
            // Arrange
            var item = new BakeryItem
            {
                Price = 3.00m,
                Quantity = 5
            };

            // Act
            var totalValue = item.GetTotalValue();

            // Assert
            Assert.That(totalValue, Is.EqualTo(15.00m));
        }

        [Test]
        public void GetTotalValue_WithZeroQuantity_ReturnsZero()
        {
            // Arrange
            var item = new BakeryItem
            {
                Price = 3.00m,
                Quantity = 0
            };

            // Act
            var totalValue = item.GetTotalValue();

            // Assert
            Assert.That(totalValue, Is.EqualTo(0m));
        }
    }
}
