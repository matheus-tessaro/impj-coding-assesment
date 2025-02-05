using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Api.Services.Interfaces;

namespace ImpjCodingAssesment.Api.Services
{
    public class SalesStatisticsService : ISalesStatisticsService
    {
        private readonly List<SalesRecordDTO> _salesRecords;
        public SalesStatisticsService(List<SalesRecordDTO> salesRecords) => _salesRecords = salesRecords;

        public StatisticsResponseDTO GetStatistics() =>
            new(GetMostCommonRegion(), 
                GetMedianUnitCost(), 
                GetTotalRevenue(), 
                GetOrderDateRange());

        private string GetMostCommonRegion() =>
            _salesRecords.GroupBy(r => r.Region).OrderByDescending(g => g.Count()).First().Key;

        private decimal GetMedianUnitCost()
        {
            var unitCosts = _salesRecords.Select(r => r.UnitCost).OrderBy(c => c).ToList();
            int count = unitCosts.Count;

            if (count % 2 == 0) return (unitCosts[count / 2 - 1] + unitCosts[count / 2]) / 2;
            return unitCosts[count / 2];
        }

        private decimal GetTotalRevenue() =>
            _salesRecords.Sum(r => r.TotalRevenue);

        private OrderDateRange GetOrderDateRange()
        {
            var firstOrderDate = _salesRecords.Min(r => r.OrderDate);
            var lastOrderDate = _salesRecords.Max(r => r.OrderDate);
            var daysInBetween = (lastOrderDate - firstOrderDate).Days;
            return new(firstOrderDate, lastOrderDate, daysInBetween);
        }
    }
}
