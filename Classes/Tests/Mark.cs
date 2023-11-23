using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes.Tests
{
    internal class Mark
    {
        public int CurrentMark { get; set; }
        public int MaxMark { get; set; }
        public Test Test { get; set; }
        public Student Student { get; set; }
    }
}
