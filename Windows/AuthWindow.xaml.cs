using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Database;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace program_for_school_tests_ukr.Windows
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var userContext = new ApplicationContext())
            {
                var user = userContext.Users.Where(x => x.Username == login.Text).FirstOrDefault();
                if (user?.Password == password.Text)
                {
                    User.CurrentUser = user;
                    MessageBox.Show(user.ToString());
                    DialogResult = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("неправильний логін, або пароль... потім перероблю");
                }
            }
        }
    }
}
