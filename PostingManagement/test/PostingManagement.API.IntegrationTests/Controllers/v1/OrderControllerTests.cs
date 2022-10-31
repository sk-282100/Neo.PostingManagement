using Newtonsoft.Json;
using PostingManagement.API.IntegrationTests.Base;
using PostingManagement.Application.Features.Orders.Queries.GetOrdersForMonth;
using PostingManagement.Application.Responses;
using Shouldly;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PostingManagement.API.IntegrationTests.Controllers.v1
{
    [Collection("Database")]
    public class OrderControllerTests : IClassFixture<WebApplicationFactory>
    {
        private readonly WebApplicationFactory _factory;
        public OrderControllerTests(WebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_OrdersForMonth_ReturnsSuccessResult()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/v1/order?date=2021-08-26&page=1&size=3");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<PagedResponse<IEnumerable<OrdersForMonthDto>>>(responseString);

            result.Data.ShouldBeOfType<List<OrdersForMonthDto>>();
            result.Data.ShouldNotBeEmpty();
        }
    }
}
