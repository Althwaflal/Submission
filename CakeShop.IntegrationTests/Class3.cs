using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CakeShop.Core.Models;
using Xunit;

namespace CakeShop.IntegrationTests
{
        public class WarehouseTests : IClassFixture<TestFixture<Startup>>
        {
            private HttpClient Client;

            public WarehouseTests(TestFixture<Startup> fixture)
            {
                Client = fixture.Client;
            }

            [Fact]
            public async Task TestPostStockItemAsync()
            {
            // Arrange
            var request = new
            {
                Url = "/4/6",
                Body = new
                {
                    OrderPlacedTime = DateTime.Now,
                    firstName = "Tory",
                    lastName = "Adderley",
                    AddressLine1 = "rrr",
                    AddressLine2 = "dddd",
                    City = "fff",
                    State = "fffs",
                    Country = "sfghfg",
                    Zipcode = "dkjdn",
                    PhoneNumber = "3342345321",
                    Email = "ff@444.com",
                    Personal_Note = "ffff",
                    UserId = "be353b5a-b4a5-434f-aac2-fbd3a6fc68be"
                }
            };

                // Act
                var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
                //var value = await response.Content.ReadAsStringAsync();

                // Assert
                response.EnsureSuccessStatusCode();
            }

        }
}
