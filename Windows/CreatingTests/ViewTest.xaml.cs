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
    /// Interaction logic for CreateTest.xaml
    /// </summary>
    public partial class ViewTest : Window
    {
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
            Test newTest = new Test();
            ViewQuestions viewQuestions = new ViewQuestions(ref newTest);
            viewQuestions.Owner = this;
            viewQuestions.Show();
            this.Hide();
        }
    }
}
