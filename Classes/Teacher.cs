using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes
{
    internal class Teacher : User
    {
        //public List<Test> OwnedTests { get; init; }

        //поле для пройдених учнями тестів з оцінками, потім реалізую
        public override string ToString()
        {
            return "Teacher";
        }
    }
}
