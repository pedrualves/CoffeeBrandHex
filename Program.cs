
using CoffeeBrand.Application;
using CoffeeBrand.Infrastructure.Repositories;
using Domain.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICoffeeBrandService, CoffeeBrandService>();
builder.Services.AddScoped<InMemoryCoffeeBrandRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// https://localhost:7263/CoffeeBrand/GetHex