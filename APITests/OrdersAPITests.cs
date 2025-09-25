using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APITests
{
    [TestFixture]
    public class OrdersAPITests
    {
        private HttpClient _client;
        private string _baseUrl = "https://127.0.0.1:7061/api";

        [SetUp]
        public void Setup()
        {
            _client = new HttpClient();
            var authToken = System.Convert.ToBase64String(
                Encoding.ASCII.GetBytes("staff:BCLyon2024"));
            _client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authToken);
        }

        [TearDown]
        public void TearDown()
        {
            _client?.Dispose();
        }

        [Test]
        public async Task GetOrders_ReturnsSuccessStatusCode()
        {
            // Act
            var response = await _client.GetAsync($"{_baseUrl}/orders");

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task GetOrderById_WithValidId_ReturnsOrder()
        {
            // Arrange
            int validId = 1;

            // Act
            var response = await _client.GetAsync($"{_baseUrl}/orders/{validId}");

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task CreateOrder_WithValidData_ReturnsCreated()
        {
            // Arrange
            var newOrder = new
            {
                product_id = 1,
                quantity = 2,
                total_price = 11.98m,
                customer_name = "Test Customer"
            };

            var json = JsonConvert.SerializeObject(newOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync($"{_baseUrl}/orders", content);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        public async Task CompleteOrder_WithValidId_ReturnsSuccess()
        {
            // Arrange
            int orderId = 1;

            // Act
            var response = await _client.PutAsync($"{_baseUrl}/orders/{orderId}/complete", null);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task CancelOrder_WithValidId_ReturnsSuccess()
        {
            // Arrange
            int orderId = 1;

            // Act
            var response = await _client.PutAsync($"{_baseUrl}/orders/{orderId}/cancel", null);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        // Black Box Testing - Test các trường hợp edge cases
        [Test]
        public async Task CreateOrder_WithNegativeQuantity_ReturnsBadRequest()
        {
            // Arrange
            var invalidOrder = new
            {
                product_id = 1,
                quantity = -1, // Số lượng âm
                total_price = -5.99m // Giá âm
            };

            var json = JsonConvert.SerializeObject(invalidOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync($"{_baseUrl}/orders", content);

            // Assert - Kiểm tra API có validate input không
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        }

        [Test]
        public async Task CreateOrder_WithNonExistentProduct_ReturnsError()
        {
            // Arrange
            var invalidOrder = new
            {
                product_id = 9999, // Product không tồn tại
                quantity = 1,
                total_price = 10.00m
            };

            var json = JsonConvert.SerializeObject(invalidOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync($"{_baseUrl}/orders", content);

            // Assert
            // Có thể là BadRequest hoặc NotFound tùy implementation
            Assert.That(response.StatusCode,
                Is.AnyOf(HttpStatusCode.BadRequest, HttpStatusCode.NotFound));
        }
    }
}
