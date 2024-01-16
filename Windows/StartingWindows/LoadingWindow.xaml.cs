using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Classes.Tests;
using program_for_school_tests_ukr.Classes.Users;
using program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows;
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

namespace program_for_school_tests_ukr.Windows
{
    /// <summary>
    /// Interaction logic for LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        public LoadingWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TestMode_RedactSimpleTest();
        }
        private void BasicRun()
        {
            BaseWindow baseWindow = new BaseWindow();
            baseWindow.Show();
            this.Close();
        }
        private void TestMode_RedactSimpleTest()
        {
            User teacher = new Teacher();
            TestInfo testInfo = new SimpleTest(teacher as Teacher);
            testInfo.Questions.Add(new QuestionAsText());
            testInfo.Questions.Add(new QuestionAsText());
            testInfo.ShowToRedact().Show();
            this.Close();
        }
    }
}
