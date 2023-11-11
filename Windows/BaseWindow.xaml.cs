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
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        AuthWindow authWindow;
        public BaseWindow()
        {
            authWindow = new AuthWindow();
            authWindow.Owner = this;
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            authWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Ще не реалізовано";
            string caption = "Не спіши";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
