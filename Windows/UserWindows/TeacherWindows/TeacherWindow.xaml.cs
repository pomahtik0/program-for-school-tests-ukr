﻿using program_for_school_tests_ukr.Classes.Users;
using program_for_school_tests_ukr.Windows.CreatingTests;
using program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows;
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
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        protected Teacher currentTeacher;
        public TeacherWindow(Teacher currentTeacher)
        {
            InitializeComponent();
            this.currentTeacher = currentTeacher;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            DataContext = currentTeacher;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            BaseWindow baseWindow = new BaseWindow();
            baseWindow.Show();
            this.Close();
        }

        private void YourTests_Button_Click(object sender, RoutedEventArgs e)
        {
            AllMyTests allMyTests = new AllMyTests(currentTeacher);
            allMyTests.Owner = this;
            allMyTests.Show();
            this.Hide();
        }

        private void ShowAllMarks_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
