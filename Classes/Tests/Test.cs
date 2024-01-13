using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_for_school_tests_ukr.Classes.Users;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public enum Subject
    {
        Математика,
        Фізика,
        Хімія,
        Українська,
        Іноземна,
        Література,
        Історія,
        Інше
    }

    public abstract class Test (Teacher owner)
    {
        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public Teacher Owner { get; private set; } = owner;
        public DateOnly DateOfLastRedaction { get; set; }
        public string Description { get; set; } = string.Empty;
        public Subject TestSubject { get; set; }
        public bool IsTrainingTest { get; set; }
        public ushort MaxMark { get; set; }
        public int TimeForTest { get; set; }
        public List<Mark> Marks { get; } = new List<Mark>();
        public List<Question> Questions { get; } = new List<Question>();
    }

    public class SimpleTest(Teacher owner) : Test(owner) 
    {
        public bool IsRandomOrdered { get; set; }
        
    }
}
