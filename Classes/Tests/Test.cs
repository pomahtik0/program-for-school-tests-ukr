using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_for_school_tests_ukr.Classes.Users;
using System.Windows;

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

    public interface ITestWindow
    {
        public Window TestWindow { get; set; }
        public int GetMark();
        public void FinishTest(); // mb not
    }

    public abstract class TestInfo (Teacher owner)
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

        public abstract class TestToPass
        {
            ITestWindow? testWindow;
            public int TimeForTest { get; set; }
            public List<Question> Questions { get; }
            public abstract ITestWindow ShowToPass();

        }
    }

    public class SimpleTest(Teacher owner) : TestInfo(owner) 
    {
        public bool IsRandomOrdered { get; set; }
        
    }
}
