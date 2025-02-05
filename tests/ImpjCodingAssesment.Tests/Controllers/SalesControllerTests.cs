using ImpjCodingAssesment.Api.Controllers;
using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Api.Services.Interfaces;
using ImpjCodingAssesment.Tests.Stubs;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ImpjCodingAssesment.Tests.Controllers
{
    public class SalesControllerTests
    {
        [Fact]
        public void GetStatistics_ReturnsCorrectStatistics()
        {
            // Arrange
            var mockStatisticsService = new Mock<ISalesStatisticsService>();
            var expectedResult = StatisticsResponseDTOStub.BuildStatisticsResponseDTOStub();
            mockStatisticsService.Setup(x => x.GetStatistics()).Returns(expectedResult);
            var controller = new SalesController(mockStatisticsService.Object);

            // Act
            var target = controller.GetStatistics();

            // Assert
            var result = Assert.IsType<OkObjectResult>(target);
            var statistics = result.Value as StatisticsResponseDTO;

            Assert.NotNull(statistics);
            Assert.Equal(expectedResult.MedianUnitCost, statistics.MedianUnitCost);
            Assert.Equal(expectedResult.MostCommonRegion, statistics.MostCommonRegion);
            Assert.Equal(expectedResult.OrderDateRange.DaysInBetween, statistics.OrderDateRange.DaysInBetween);
            Assert.Equal(expectedResult.TotalRevenue, statistics.TotalRevenue);
        }
    }
}
