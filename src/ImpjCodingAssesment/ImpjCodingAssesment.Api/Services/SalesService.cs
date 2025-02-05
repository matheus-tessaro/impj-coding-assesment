using CsvHelper;
using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Api.Services.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System.Globalization;

namespace ImpjCodingAssesment.Api.Services
{
    public class SalesService : ISalesService
    {
        private readonly IMemoryCache _cache;
        private const string CacheKey = "SalesRecords";

        public SalesService(IMemoryCache cache) => _cache = cache;

        public List<SalesRecordDTO> GetSalesRecords()
        {
            if (!_cache.TryGetValue(CacheKey, out List<SalesRecordDTO> salesRecords))
            {
                salesRecords = ParseCsvRecordsToDto();
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(10));
                _cache.Set(CacheKey, salesRecords, cacheEntryOptions);
            }

            return salesRecords;
        }

        private static List<SalesRecordDTO> ParseCsvRecordsToDto()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "SalesRecords.csv");
            using StreamReader reader = new(filePath);
            using CsvReader csv = new(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<SalesRecordDTO>().ToList();
        }
    }
}
