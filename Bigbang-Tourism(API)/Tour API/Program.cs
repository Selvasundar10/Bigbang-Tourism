using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using Tour_API.Repository.Interface;
using Tour_API.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TourContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "Tourism")));
builder.Services.AddScoped<ITour, TourService>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<ITourSpot, TourSpotService>();



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


