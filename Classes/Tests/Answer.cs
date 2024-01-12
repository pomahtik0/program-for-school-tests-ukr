using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public abstract class Answer
    {
        public int Id { get; set; }
        public abstract UserControl Show();
        public abstract UserControl ShowInRedactMode();
    }
}
