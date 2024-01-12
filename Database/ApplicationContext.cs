using Microsoft.EntityFrameworkCore;
using program_for_school_tests_ukr.Classes.Tests;
using program_for_school_tests_ukr.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Database
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Question> Question { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pomahtik\source\repos\program for school tests ukr\Database\Database.mdf"";Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("User_type")  //creating separator field for different type of users
                .HasValue<Student>("Student")           
                .HasValue<Teacher>("Teacher");

            modelBuilder.Entity<Mark>()                 // no cascade, due to sql server restrictions
                .HasOne(e => e.Test)                    // should consider about switching to mysql
                .WithMany(e => e.Marks)                 // or delete marks manualy before deleting test
                .HasForeignKey("TestId")                // (two FK cascade prohibited)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
