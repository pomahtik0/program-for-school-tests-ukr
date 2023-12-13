using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText {  get; set; }
        public Question AnswerToQuestion { get; set; }
        public bool IsRealAnswer { get; set; }
    }
}
