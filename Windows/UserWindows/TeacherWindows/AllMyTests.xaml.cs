using program_for_school_tests_ukr.Classes.Users;
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
    /// Interaction logic for AllMyTests.xaml
    /// </summary>
    public partial class AllMyTests : Window
    {
        protected Teacher currentTeacher;
        public AllMyTests(Teacher teacher)
        {
            InitializeComponent();
            this.currentTeacher = teacher;
        }
    }
}
