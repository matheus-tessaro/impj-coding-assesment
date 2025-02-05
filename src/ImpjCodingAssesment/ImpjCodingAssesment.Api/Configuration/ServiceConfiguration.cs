using ImpjCodingAssesment.Api.Services;
using ImpjCodingAssesment.Api.Services.Interfaces;

namespace ImpjCodingAssesment.Api.Configuration
{
    public static class ServiceConfiguration
    {
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<ISalesService, SalesService>();
            services.AddScoped<ISalesStatisticsService, SalesStatisticsService>(sp =>
            {
                var salesService = sp.GetRequiredService<ISalesService>();
                return new SalesStatisticsService(salesService.GetSalesRecords());
            });
        }
    }
}
