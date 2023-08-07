using BookingAPI.DB;
using Microsoft.EntityFrameworkCore;
using Tour_API.Repository.Interface;
using Tour_API.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookingContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "Tourism")));
builder.Services.AddScoped<IFeedback, FeedbackService>();
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

app.MapControllers();

app.Run();
