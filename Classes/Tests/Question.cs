using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; } = new List<Answer>();
        public string AnswerDescription { get; set; }
    }
}
