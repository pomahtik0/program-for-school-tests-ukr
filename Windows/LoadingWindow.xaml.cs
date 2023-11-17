using program_for_school_tests_ukr.Classes;
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
            var userContext = new UserContext();
            userContext.Add(new Teacher() { Name = "Teacher Best", Username = "teacher1", Password = "teacher1" });
            userContext.SaveChanges();
            BaseWindow baseWindow = new BaseWindow();
            baseWindow.Show();
            this.Close();
        }
    }
}
