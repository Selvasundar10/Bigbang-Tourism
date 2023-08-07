using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using Tour_API.Repository.Interface;
using Tour_API.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Environment.EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TourContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "Tourism")));
builder.Services.AddScoped<ITour, TourService>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IItinerary, ItineraryService>();
builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddCors(op =>
{
    op.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyCorsPolicy");
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();


