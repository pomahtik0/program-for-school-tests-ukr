using program_for_school_tests_ukr.Classes;
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

namespace program_for_school_tests_ukr.Windows.CreatingTests
{
    /// <summary>
    /// Interaction logic for ViewQuestions.xaml
    /// </summary>
    public partial class ViewQuestions : Window
    {
        public Test currentTest;
        public ViewQuestions(int testId)
        {
            SetCurrentTest(testId);
            InitializeComponent();
        }

        private void SetCurrentTest(int testId)
        {
            if (testId == 0)
            {
                currentTest = new Test();
                try
                {
                    currentTest.Owner = User.CurrentUser as Teacher;
                }
                catch 
                {
                    throw new Exception("unnexpected error with current user");
                }
            }
            else; // прочитати з БД
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //save object
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
