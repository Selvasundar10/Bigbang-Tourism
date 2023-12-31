﻿using Microsoft.EntityFrameworkCore;
using ModelsLibrary;

namespace UserAPI.DB
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> User { get; set; }

        public DbSet<Travel_Agent> Travel_Agent { get; set; }


        public DbSet<Gallery> Gallery { get; set; }




    }
}
