using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Classes.Tests;
using program_for_school_tests_ukr.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for CreateTest.xaml
    /// </summary>
    public partial class ViewTest : Window
    {
        List<Test> Tests;
        public ViewTest()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void CreateTest_Button_Click(object sender, RoutedEventArgs e)
        {
            ViewQuestions viewQuestions = new ViewQuestions(0); // create empty test
            viewQuestions.Owner = this;
            viewQuestions.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var dbcontext = new ApplicationContext()) {
                Tests = dbcontext.Tests.Where(x=>x.Owner == User.CurrentUser).ToList();
            }
            DataContext = Tests;
        }

        private void DeleteTest_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var dbcontext = new ApplicationContext())
            {
                try
                {
                    Test testToDelete = listOfTests.SelectedItem as Test;
                    dbcontext.Tests.Remove(testToDelete);
                    dbcontext.SaveChanges();
                    Tests.Remove(testToDelete);
                }
                catch
                {
                    Debug.WriteLine("error when deleting test");
                }
            }
        }

        private void UpdateTest_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateDataContext()
        { 
        
        }
    }
}
