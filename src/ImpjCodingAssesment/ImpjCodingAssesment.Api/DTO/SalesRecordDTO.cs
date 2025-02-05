using CsvHelper.Configuration.Attributes;

namespace ImpjCodingAssesment.Api.DTO
{
    public class SalesRecordDTO
    {
        [Name("Order ID")]
        public long OrderId { get; set; }

        [Name("Units Sold")]
        public int UnitsSold { get; set; }

        [Name("Unit Price")]
        public decimal UnitPrice { get; set; }

        [Name("Unit Cost")]
        public decimal UnitCost { get; set; }

        [Name("Total Revenue")]
        public decimal TotalRevenue { get; set; }

        [Name("Total Cost")]
        public decimal TotalCost { get; set; }

        [Name("Total Profit")]
        public decimal TotalProfit { get; set; }

        [Name("Region")]
        public string Region { get; set; }

        [Name("Country")]
        public string Country { get; set; }

        [Name("Item Type")]
        public string ItemType { get; set; }

        [Name("Sales Channel")]
        public string SalesChannel { get; set; }

        [Name("Order Priority")]
        public string OrderPriority { get; set; }

        [Name("Order Date")]
        public DateTime OrderDate { get; set; }

        [Name("Ship Date")]
        public DateTime ShipDate { get; set; }
    }
}
