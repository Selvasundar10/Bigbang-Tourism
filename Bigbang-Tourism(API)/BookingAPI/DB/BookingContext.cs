using Microsoft.EntityFrameworkCore;
using ModelsLibrary;

namespace BookingAPI.DB
{
    public class BookingContext : DbContext
    {
      
        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }

        public DbSet<Booking_Details> Booking { get; set; }

        public DbSet<Feedbacks> Feedbacks { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Travel_Agent> Travel_Agent { get; set; }
        public DbSet<Tour> Tour { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .Property(t => t.Cost)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Booking_Details>()
                .Property(b => b.BillingPrice)
                .HasColumnType("decimal(18, 2)");
        }


    }
}

