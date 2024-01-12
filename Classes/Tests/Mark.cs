using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_for_school_tests_ukr.Classes.Users;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public class Mark
    {
        public int Id {  get; private set; }
        public int CurrentMark { get; private set; }
        public int MaxMark { get; private set; }
        public Test Test { get; private set; }
        public Student MarkOfStudent { get; private set; }
    }
}
