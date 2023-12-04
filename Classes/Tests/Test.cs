using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Історія
    }
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Owner { get; set; }
        public string Description { get; set; }
        public Subject TestSubject { get; set; }
        public bool IsRandomOrdered { get; set; }
        public bool IsTrainingTest { get; set; }
        public bool GetRandomTests { get; set; } // Обрати випадкові запитання зі списку
        public int QuestionCount { get; set; } // Кількість запитань
        public List<Mark> Marks { get; set; } = new List<Mark>();
        public List<Question> questions { get; set; } = new List<Question>();
    }
}
