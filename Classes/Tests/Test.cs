using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes.Tests
{
    internal class Test
    {
        public string Name { get; private set; }
        public Teacher Owner { get; init; }
        public bool IsRandomOrdered { get; private set; }
        public bool GetRandomTests { get; private set; } // Обрати випадкові запитання зі списку
        public int QuestionCount { get; private set; } // Кількість запитань
        public int[] LeveledQuestionCount { get; init; } // Кількість запитань

        //результат виражається оцінкою чи відповіддю?

        //поле з історією проходження цього тесту


    }
}
