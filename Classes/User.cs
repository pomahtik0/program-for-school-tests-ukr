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
        public string Username { get; private set; }
        public string Name { get; private set; }
        private string Password { get; set; }

        public User(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }
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
