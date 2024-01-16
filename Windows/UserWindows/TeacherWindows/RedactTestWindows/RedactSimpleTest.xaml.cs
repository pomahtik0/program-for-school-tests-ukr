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

namespace program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows
{
    /// <summary>
    /// Interaction logic for RedactTest.xaml
    /// </summary>
    public partial class RedactSimpleTest : Window
    {
        SimpleTest test;
        public RedactSimpleTest(SimpleTest testToRedact)
        {
            InitializeComponent();
            test = testToRedact;
        }

        private void OnWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
