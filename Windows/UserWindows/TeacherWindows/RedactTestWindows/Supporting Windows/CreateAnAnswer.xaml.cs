using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows.RedactTestWindows.Supporting_Windows
{
    /// <summary>
    /// Interaction logic for CreateAnAnswer.xaml
    /// </summary>
    public partial class CreateAnAnswer : Window
    {
        IEnumerable<Answer> answers;
        Question currentQuestion;
        public CreateAnAnswer(IEnumerable<Answer> answers, Question currentQuestion)
        {
            InitializeComponent();
            this.answers = answers;
            this.currentQuestion = currentQuestion;
        }
    }
}
