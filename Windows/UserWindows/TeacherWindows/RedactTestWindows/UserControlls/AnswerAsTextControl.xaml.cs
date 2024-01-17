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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows.RedactTestWindows.UserControlls
{
    /// <summary>
    /// Interaction logic for AnswerControl.xaml
    /// </summary>
    public partial class AnswerAsTextControl : UserControl
    {
        TextAnswer textAnswer;
        public AnswerAsTextControl(TextAnswer textAnswer)
        {
            InitializeComponent();
            this.textAnswer = textAnswer;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = textAnswer;
        }
    }
}
