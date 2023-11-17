using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace program_for_school_tests_ukr.Classes
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set;}
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Student> Students { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DBCS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("user_type")
                .HasValue<Student>("student")
                .HasValue<Teacher>("teacher");
        }

    }
}
