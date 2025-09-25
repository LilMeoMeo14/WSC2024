using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace APITests
{
    public class Tests
    {
        [TestFixture]
        public class ProductsAPITests
        {
            private HttpClient _client;
            private string _baseUrl = "https://127.0.0.1:7061/api"; // Thay bằng URL thực tế của bạn

            [SetUp]
            public void Setup()
            {
                _client = new HttpClient();
                // Thêm authentication header (Basic Auth)
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
            public async Task GetProducts_ReturnsSuccessStatusCode()
            {
                // Act
                var response = await _client.GetAsync($"{_baseUrl}/products");

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }

            [Test]
            public async Task GetProductById_WithValidId_ReturnsProduct()
            {
                // Arrange
                int validId = 1;

                // Act
                var response = await _client.GetAsync($"{_baseUrl}/products/{validId}");

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

                var content = await response.Content.ReadAsStringAsync();
                Assert.That(content, Is.Not.Empty);
            }

            [Test]
            public async Task GetProductById_WithInvalidId_ReturnsNotFound()
            {
                // Arrange
                int invalidId = 9999; // ID không tồn tại

                // Act
                var response = await _client.GetAsync($"{_baseUrl}/products/{invalidId}");

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            }

            [Test]
            public async Task CreateProduct_WithValidData_ReturnsCreated()
            {
                // Arrange
                var newProduct = new
                {
                    name = "Test Product " + DateTime.Now.Ticks,
                    price = 5.99m,
                    stock = 10,
                    category = "Test Category"
                };

                var json = JsonConvert.SerializeObject(newProduct);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Act
                var response = await _client.PostAsync($"{_baseUrl}/products", content);

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            }

            [Test]
            public async Task CreateProduct_WithInvalidData_ReturnsBadRequest()
            {
                // Arrange - Tạo product với data không hợp lệ (thiếu name)
                var invalidProduct = new
                {
                    price = 5.99m,
                    stock = 10
                    // Thiếu trường name
                };

                var json = JsonConvert.SerializeObject(invalidProduct);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Act
                var response = await _client.PostAsync($"{_baseUrl}/products", content);

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
            }

            [Test]
            public async Task UpdateProduct_WithValidData_ReturnsSuccess()
            {
                // Arrange
                int productId = 1; // Thay bằng ID tồn tại
                var updatedProduct = new
                {
                    name = "Updated Product",
                    price = 6.99m,
                    stock = 15
                };

                var json = JsonConvert.SerializeObject(updatedProduct);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Act
                var response = await _client.PutAsync($"{_baseUrl}/products/{productId}", content);

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }

            [Test]
            public async Task DeleteProduct_WithValidId_ReturnsSuccess()
            {
                // Arrange
                int productId = 2; // Thay bằng ID tồn tại

                // Act
                var response = await _client.DeleteAsync($"{_baseUrl}/products/{productId}");

                // Assert
                // Có thể là OK hoặc NoContent tùy implementation
                Assert.That(response.StatusCode,
                    Is.AnyOf(HttpStatusCode.OK, HttpStatusCode.NoContent));
            }

            [Test]
            public async Task AccessWithoutAuthentication_ReturnsUnauthorized()
            {
                // Arrange
                var clientWithoutAuth = new HttpClient();

                // Act
                var response = await clientWithoutAuth.GetAsync($"{_baseUrl}/products");

                // Assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized));
            }
        }
    }
}
