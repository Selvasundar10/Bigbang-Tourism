using Microsoft.EntityFrameworkCore;
using ModelsLibrary;

namespace Tour_API.DB
{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options) { }



        public DbSet<Tour> Tour { get; set; }

        public DbSet<Hotel> Hotel { get; set; }


        public DbSet<TourSpot> TourSpots { get; set; }

        public DbSet<Travel_Agent> Travel_Agent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            // Your other configurations...
            modelBuilder.Entity<Tour>()
             .Property(b => b.Cost)
             .HasColumnType("decimal(18, 2)");
        }



    }
}
