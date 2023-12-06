using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes
{
    public class Teacher : User
    {
        public List<Test> OwnedTests { get; } = new List<Test>();

        //поле для пройдених учнями тестів з оцінками, потім реалізую
        public override string ToString()
        {
            return "Teacher";
        }
    }
}
