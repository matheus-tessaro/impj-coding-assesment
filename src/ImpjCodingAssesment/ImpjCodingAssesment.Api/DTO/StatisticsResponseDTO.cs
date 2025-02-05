namespace ImpjCodingAssesment.Api.DTO
{
    public class StatisticsResponseDTO(string mostCommonRegion, decimal medianUnitCost, decimal totalRevenue, OrderDateRange orderDateRange)
    {
        public string MostCommonRegion { get; private set; } = mostCommonRegion;
        public decimal MedianUnitCost { get; private set; } = medianUnitCost;
        public decimal TotalRevenue { get; private set; } = totalRevenue;
        public OrderDateRange OrderDateRange { get; private set; } = orderDateRange;
    }

    public class OrderDateRange(DateTime firstOrderDate, DateTime lastOrderDate, int daysInBetween)
    {
        public DateTime FirstOrderDate { get; private set; } = firstOrderDate;
        public DateTime LastOrderDate { get; private set; } = lastOrderDate;
        public int DaysInBetween { get; private set; } = daysInBetween;
    }
}
