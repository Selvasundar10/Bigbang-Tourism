using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Booking_API.DB
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }
        public DbSet<Booking_Details> Booking_Details { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specify the SQL server column type for the 'Cost' property of the 'Tour' entity.
            modelBuilder.Entity<Booking_Details>()
                .Property(t => t.BillingPrice)
                .HasColumnType("decimal(18, 2)");

            // Your other configurations...
            modelBuilder.Entity<Tour>()
             .Property(b => b.Cost)
             .HasColumnType("decimal(18, 2)");
        }
    }
}
