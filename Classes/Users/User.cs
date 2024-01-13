using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Navigation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace program_for_school_tests_ukr.Classes.Users
{
    public abstract class User
    {
        public int Id { get; set; }
        [Unicode(false)]
        [MaxLength(20)]
        public string Username { get; set; } = string.Empty;
        [Unicode]
        [MaxLength(120)]
        public string Name { get; set; } = string.Empty;
        [Unicode(false)]
        [MaxLength(20)]
        public string Password { get; set; } = string.Empty;
        [NotMapped]
        protected Window? currentWindow;
        public abstract Window GetWindow();
    }
}
