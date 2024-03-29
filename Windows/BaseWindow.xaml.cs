﻿using program_for_school_tests_ukr.Classes.Users;
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
        public BaseWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Owner = this;
            if (authWindow.ShowDialog() == true)
            {
                if (User.CurrentUser?.ToString() == "Teacher") // вхід вчителя
                {
                    TeacherWindow teacherWindow = new TeacherWindow();
                    teacherWindow.Show();
                    this.Close();
                }
                else // вхід студента
                {
                    StudentWindow studentWindow = new StudentWindow();
                    studentWindow.Show();
                    this.Close();
                }
            }
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
