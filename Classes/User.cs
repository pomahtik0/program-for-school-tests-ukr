using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Student> Students { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(App.Current.Properties["connectionString"]?.ToString());
        }

    }
}
