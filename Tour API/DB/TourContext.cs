using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;

namespace Tour_API.DB
{
    public class TourContext :DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options) { }


        public DbSet<Tour> Tour { get; set; }


        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<Travel_Agent> Travel_Agent { get; set; }

        public DbSet<Booking_Details> Booking_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking_Details>()
           .Property(b => b.BillingPrice)
           .HasColumnType("decimal(18, 2)");

            // Your other configurations...
            modelBuilder.Entity<Tour>()
             .Property(b => b.Cost)
             .HasColumnType("decimal(18, 2)");
        }


    }
}
