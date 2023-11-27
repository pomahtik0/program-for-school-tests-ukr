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
        public ViewQuestions(ref Test currentTest)
        {
            this.currentTest = currentTest;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
