using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Api.Services;
using ImpjCodingAssesment.Tests.Stubs;

namespace ImpjCodingAssesment.Tests.Services
{
    public class SalesStatisticsServiceTests
    {
        [Fact]
        public void GetStatistics_ReturnsCorrectStatistics()
        {
            // Arrange
            var testRecords = SalesRecordDTOStub.BuildSalesRecordDTOStub();
            var service = new SalesStatisticsService(testRecords);

            // Act
            var result = service.GetStatistics();

            // Assert
            List<decimal> unitCosts = testRecords.Select(r => r.UnitCost).OrderBy(c => c).ToList();
            decimal expectedMedian = (unitCosts[2] + unitCosts[3]) / 2;
            decimal expectedTotalRevenue = testRecords.Sum(r => r.TotalRevenue);

            DateTime firstOrderDate = testRecords.Min(r => r.OrderDate);
            DateTime lastOrderDate = testRecords.Max(r => r.OrderDate);
            int daysInBetween = (lastOrderDate - firstOrderDate).Days;

            Assert.NotNull(result);
            Assert.Equal("South America", result.MostCommonRegion);
            Assert.Equal(expectedMedian, result.MedianUnitCost);
            Assert.Equal(expectedTotalRevenue, result.TotalRevenue);
            Assert.Equal(firstOrderDate, result.OrderDateRange.FirstOrderDate);
            Assert.Equal(lastOrderDate, result.OrderDateRange.LastOrderDate);
            Assert.Equal(daysInBetween, result.OrderDateRange.DaysInBetween);
        }

        [Fact]
        public void GetStatistics_EmptyList_ThrowsException()
        {
            // Arrange
            var emptyList = new List<SalesRecordDTO>();
            var service = new SalesStatisticsService(emptyList);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => service.GetStatistics());
        }
    }
}
