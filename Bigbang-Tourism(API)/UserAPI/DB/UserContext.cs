using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;

namespace UserAPI.DB
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<TourSpot> Users { get; set; }
    }
}
