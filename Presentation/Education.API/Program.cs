 using Core.CrossCuttingConcerns.Exceptions;
using Education.Application;
using Education.Infrastructure;
using Education.Infrastructure.Services.Storage.Local;
using Education.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPersistanceServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();

builder.Services.AddStorage<LocalStorage>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

//if (app.Environment.IsDevelopment())
//    app.ConfigureCustomExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
