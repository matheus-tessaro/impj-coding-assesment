using ImpjCodingAssesment.Api.DTO;

namespace ImpjCodingAssesment.Api.Services.Interfaces
{
    public interface ISalesService
    {
        List<SalesRecordDTO> GetSalesRecords();
    }
}
