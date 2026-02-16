using EmergencyDispatchService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRouting();

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapControllers();

app.Run();