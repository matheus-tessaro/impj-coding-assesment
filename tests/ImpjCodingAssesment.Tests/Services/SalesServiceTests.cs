using ImpjCodingAssesment.Api.Services;
using Microsoft.Extensions.Caching.Memory;

namespace ImpjCodingAssesment.Tests.Services
{
    public class SalesServiceTests
    {
        [Fact]
        public void GetSalesRecords_ReturnsCorrectData()
        {
            // Arrange
            var cache = new MemoryCache(new MemoryCacheOptions());
            var salesService = new SalesService(cache);

            // Act
            var salesRecords = salesService.GetSalesRecords();

            // Assert
            Assert.NotNull(salesRecords);
            Assert.NotEmpty(salesRecords);
            Assert.Equal(100000, salesRecords.Count);
        }

        [Fact]
        public void GetSalesRecords_CachesData()
        {
            // Arrange
            var cache = new MemoryCache(new MemoryCacheOptions());
            var salesService = new SalesService(cache);

            // Act
            var firstCall = salesService.GetSalesRecords();
            var secondCall = salesService.GetSalesRecords();

            // Assert
            Assert.Same(firstCall, secondCall);
        }
    }
}
