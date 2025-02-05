using ImpjCodingAssesment.Api.DTO;
using ImpjCodingAssesment.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ImpjCodingAssesment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesStatisticsService _statisticsService;
        public SalesController(ISalesStatisticsService statisticsService) => _statisticsService = statisticsService;

        [HttpGet("statistics")]
        [ProducesResponseType(typeof(StatisticsResponseDTO), StatusCodes.Status200OK)]
        public IActionResult GetStatistics() => Ok(_statisticsService.GetStatistics());
    }
}
