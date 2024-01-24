using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_for_school_tests_ukr.Classes.Users;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows;
using System.Collections.ObjectModel;

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

    public abstract class TestInfo (Teacher owner)
    {
        public int Id { get; private set; }

        [Unicode]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public virtual Teacher Owner { get; private set; } = owner;
        public DateOnly DateOfLastRedaction { get; set; }

        [Unicode]
        [MaxLength(256)]
        public string Description { get; set; } = string.Empty;
        public Subject TestSubject { get; set; }
        public ushort Grade {  get; set; } // Клас для якого призначений 
        public bool IsTrainingTest { get; set; }
        public bool IsAvailbleForTesting { get; set; }
        public ushort MaxMark { get; set; }
        public int TimeForTest { get; set; }
        public virtual List<Mark> Marks { get; } = new List<Mark>();
        public virtual ObservableCollection<Question> Questions { get; } = [];

        public abstract class TestToPass
        {
            Window? testWindow;
            public int TimeForTest { get; set; }
            public List<Question> Questions { get; protected set; } = null!; // must set in divired class
            public abstract Window ShowToPass();

        }

        [NotMapped]
        protected TestToPass? testToPass;
        public abstract Window ShowToRedact();
        public abstract Window ShowToPass();
        public abstract void AddQuestion(Question question, object? parameters = null);
    }

    public class SimpleTest(Teacher teacher) : TestInfo(teacher)
    {
        public bool IsRandomOrdered { get; set; }

        public class SimpleTestToPass : TestToPass
        {
            public SimpleTestToPass(TestInfo mainTest) 
            {
                Questions = new List<Question>(mainTest.Questions); // make it random ordered if needed
            }
            public override Window ShowToPass()
            {
                throw new NotImplementedException();
            }
        }
        public override Window ShowToRedact()
        {
            return new RedactSimpleTest(this);
        }

        public override Window ShowToPass()
        {
            throw new NotImplementedException();
        }

        public override void AddQuestion(Question question, object? parameters = null)
        {
            Questions.Add(question);
        }
    }
}
