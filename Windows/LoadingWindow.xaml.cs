using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Classes.Tests;
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
            using (var dbcontext = new ApplicationContext())
            {
                var stud1 = new Student() { Name = "st", Username = "stud1", Password = "stud1" };
                var stud2 = new Student() { Name = "stu", Username = "stud2", Password = "stud2" };
                var teacher1 = new Teacher() { Name = "teacher", Username = "teacher1", Password = "teacher1" };
                Test test = new Test() { Name = "test1", Owner = teacher1, Description = "test", IsRandomOrdered = true, DateOfLastRedaction = DateOnly.FromDateTime(DateTime.Now), TestSubject = Subject.Математика, IsTrainingTest = false };
                dbcontext.Users.Add(stud1);
                dbcontext.Users.Add(stud2);
                dbcontext.Users.Add(teacher1);
                dbcontext.Tests.Add(test);
                dbcontext.SaveChanges();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BaseWindow baseWindow = new BaseWindow();
            baseWindow.Show();
            this.Close();
        }
    }
}
