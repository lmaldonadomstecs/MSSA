using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChallengeFriendslist.Models;

namespace ChallengeFriendslist.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext (DbContextOptions<FriendContext> options) : base(options)
        {

        }

        // Accesing a table in the database
        public DbSet<Friend> Friend { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // I think I'm forgetting something
            modelBuilder.Entity<Friend>().HasData(
                    new Friend() { id = 1, name = "León", place = "México", age = 17, occupation = "Pizza Delivery Guy", favoriteSport = "F1" },
                    new Friend() { id = 2, name = "John", place = "Puerto Rico", age = 43, occupation = "Entrepreneur", favoriteSport = "Soccer" },
                    new Friend() { id = 3, name = "Jane", place = "Hawaii", age = 35, occupation = "Lawyer", favoriteSport = "Hockey" }
                );
        }
    }
}
