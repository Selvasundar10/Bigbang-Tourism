using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;

namespace UserAPI.DB
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> User { get; set; }

        public DbSet<Travel_Agent> Travel_Agent { get; set; }

        public DbSet<Feedbacks> Feedbacks { get; set; }

        public DbSet<Gallery> Gallery { get; set; }




    }
}
