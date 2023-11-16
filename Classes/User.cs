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
    }

    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; private set;}

    }
}
