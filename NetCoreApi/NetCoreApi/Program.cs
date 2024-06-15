using Models;
using Services.Implementations;
using Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using NetCoreApi.MappingProfile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NetCoreApiContext>(options =>
    options.UseSqlServer("Provide connection string here"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapper = new MapperConfiguration(mp =>
{
    mp.AddProfile(new MappingProfile());
});

var maping = mapper.CreateMapper();
builder.Services.AddSingleton(maping);

builder.Services.AddScoped<IHomeService, HomeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
