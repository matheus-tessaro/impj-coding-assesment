using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Tests.Utils;

namespace ImpjCodingAssesment.Tests.Stubs
{
    internal static class StatisticsResponseDTOStub
    {
        public static StatisticsResponseDTO BuildStatisticsResponseDTOStub() =>
            new(Randomizer.RandomString(15), Randomizer.RandomDecimal(), Randomizer.RandomDecimal(), BuildOrderDateRangeStub());

        private static OrderDateRange BuildOrderDateRangeStub()
        {
            var currentDate = DateTime.Now;
            var firstOrderDate = currentDate.AddYears(-14);
            var lastOrderDate = currentDate.AddHours(-8);
            var daysInBetween = (lastOrderDate - firstOrderDate).Days;
            return new(firstOrderDate, lastOrderDate, daysInBetween);
        }
    }
}
