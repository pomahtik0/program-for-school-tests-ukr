using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_for_school_tests_ukr.Classes.Users
{
    public class Student : User
    {
        public List<Mark> Marks { get; } = new List<Mark>(); // Lazy Load?!

        public override Window GetWindow()
        {
            throw new NotImplementedException();
        }
    }
}
