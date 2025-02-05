using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Tests.Utils;

namespace ImpjCodingAssesment.Tests.Stubs
{
    internal static class SalesRecordDTOStub
    {
        public static List<SalesRecordDTO> BuildSalesRecordDTOStub() =>
            [
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 10,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "Europe",
                    Country = "Italy",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddYears(-10),
                    ShipDate = DateTime.Now.AddDays(5).AddYears(-10),
                },
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 15,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "Europe",
                    Country = "Spain",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddDays(-10),
                    ShipDate = DateTime.Now.AddDays(-2)
                },
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 20,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "South America",
                    Country = "Brazil",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddMonths(-5),
                    ShipDate = DateTime.Now.AddMonths(-3)
                },
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 32,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "South America",
                    Country = "Argentina",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddYears(-1),
                    ShipDate = DateTime.Now.AddMonths(-7)
                },
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 40,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "South America",
                    Country = "Bolivia",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddYears(-3),
                    ShipDate = DateTime.Now.AddDays(10).AddYears(-3)
                },
                new()
                {
                    OrderId = Randomizer.RandomLong(),
                    UnitsSold = Randomizer.RandomInt(),
                    UnitPrice = Randomizer.RandomDecimal(),
                    UnitCost = 59,
                    TotalRevenue = Randomizer.RandomDecimal(),
                    TotalCost = Randomizer.RandomDecimal(),
                    TotalProfit = Randomizer.RandomDecimal(),
                    Region = "North America",
                    Country = "United States",
                    ItemType = Randomizer.RandomString(10),
                    SalesChannel = Randomizer.RandomString(5),
                    OrderPriority = Randomizer.RandomString(1),
                    OrderDate = DateTime.Now.AddYears(-3),
                    ShipDate = DateTime.Now.AddMonths(-7)
                }
            ];
    }
}
