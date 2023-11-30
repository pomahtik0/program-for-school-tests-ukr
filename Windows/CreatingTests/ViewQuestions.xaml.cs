using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Classes.Tests;
using program_for_school_tests_ukr.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        public Test currentTest = new Test();
        public ViewQuestions(int testId)
        {
            InitializeComponent();
            SetCurrentTest(testId);
        }

        private void SetCurrentTest(int testId)
        {
            if (testId == 0)
            {
                currentTest = new Test();
                try
                {
                    currentTest.Owner = (Teacher)User.CurrentUser;
                }
                catch
                {
                    throw new Exception("unnexpected error with current user");
                }
            }
            else
            {
                using(var dbcontext = new ApplicationContext())
                try
                {
                        currentTest = dbcontext.Tests.First(x => x.Id == testId);
                }
                catch
                {
                        MessageBox.Show("Тест не знайдено!");
                }
            }
            window.DataContext = currentTest;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTest();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentTest(currentTest.Id);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("Зберегти данні перед виходом?", "Вихід", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SaveTest();
            }
        }

        private void CreateNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            Question newQuestion = new Question();
            CreateRedactQuestion questionWindow = new CreateRedactQuestion(newQuestion);
            questionWindow.Owner = this;
            this.Hide();
            if (questionWindow.ShowDialog() == true)
            {
                currentTest.questions.Add(newQuestion);
            }
            this.Show();
        }
        private bool SaveTest()
        {
            try
            {
                using (var dbContext = new ApplicationContext())
                {
                    dbContext.Attach(currentTest.Owner);
                    dbContext.Tests.Add(currentTest);
                    dbContext.SaveChanges();
                    DialogResult = true; // дані було збережено
                }
            }
            catch(InvalidOperationException)
            {
                Debug.WriteLine("can't save dialog result for non dialog window");
                return false;
            }
            catch
            {
                Debug.WriteLine("some other db error");
                return false;
            }
            
            return true;
        }
    }
}
