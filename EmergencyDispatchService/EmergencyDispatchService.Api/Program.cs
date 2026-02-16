using EmergencyDispatchService.Infrastructure;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddRouting();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddSwaggerGen();


var app = builder.Build();

app.MapControllers();


app.UseSwagger();
app.UseSwaggerUI();


app.Run();
