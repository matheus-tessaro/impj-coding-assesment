using ImpjCodingAssesment.Api.Configuration;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();
builder.Services.AddServiceConfiguration();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapScalarApiReference();
app.MapOpenApi();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
