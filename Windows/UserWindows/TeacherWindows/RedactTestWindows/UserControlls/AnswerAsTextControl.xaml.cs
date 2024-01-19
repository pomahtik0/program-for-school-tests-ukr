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
            this.textAnswer = textAnswer;
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if(radioButton.IsChecked == true)
            {
                textAnswer.AnswerToQuestion.ActualAnswer = textAnswer;
            }
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            DataContext = textAnswer;
            if (textAnswer.AnswerToQuestion.ActualAnswer?.Equals(textAnswer) == true)
                radioButton.IsChecked = true;
        }

        private void DeleteThisAnswer_Click(object sender, RoutedEventArgs e)
        {
            textAnswer.AnswerToQuestion.Answers.Remove(textAnswer);
            if (textAnswer.AnswerToQuestion.ActualAnswer == textAnswer)
                textAnswer.AnswerToQuestion.ActualAnswer = null;

            var parentPanel = this.Parent as Panel;
            parentPanel?.Children.Remove(this);
        }
    }
}
