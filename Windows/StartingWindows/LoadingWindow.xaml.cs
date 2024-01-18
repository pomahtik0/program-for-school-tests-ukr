﻿using program_for_school_tests_ukr.Classes;
using program_for_school_tests_ukr.Classes.Tests;
using program_for_school_tests_ukr.Classes.Users;
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
            TestMode_RedactSimpleTest();
        }
        private void BasicRun()
        {
            BaseWindow baseWindow = new BaseWindow();
            baseWindow.Show();
            this.Close();
        }
        private void TestMode_RedactSimpleTest()
        {
            Teacher teacher = new Teacher();
            TestInfo testInfo = new SimpleTest(teacher);
            var q1 = new QuestionAsText();
            var q2 = new QuestionAsText();
            testInfo.Questions.Add(q1);
            testInfo.Questions.Add(q2);
            var a1 = new TextAnswer(q1);
            var a2 = new TextAnswer(q1);
            q1.ActualAnswer = a2;
            var a3 = new TextAnswer(q2);
            var a4 = new TextAnswer(q2);
            testInfo.ShowToRedact().Show();
            this.Close();
        }
    }
}
