﻿using program_for_school_tests_ukr.Classes;
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

namespace program_for_school_tests_ukr.Windows.CreatingTests
{
    /// <summary>
    /// Interaction logic for ViewQuestions.xaml
    /// </summary>
    public partial class ViewQuestions : Window
    {
        public Test currentTest = new Test();
        public ViewQuestions(int testId)
        {
            InitializeComponent();
            SetCurrentTest(testId);
        }

        private void SetCurrentTest(int testId)
        {
            if (testId == 0)
            {
                currentTest = new Test();
                try
                {
                    currentTest.Owner = (Teacher)User.CurrentUser;
                }
                catch
                {
                    throw new Exception("unnexpected error with current user");
                }
            }
            else ; // прочитати з БД
            window.DataContext = currentTest;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using(var dbContext = new ApplicationContext())
            {
                dbContext.Add(currentTest);
                dbContext.SaveChanges();
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SetCurrentTest(currentTest.Id);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("Зберегти данні перед виходом?", "Вихід", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //save object
            }
        }

        private void CreateNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            Question newQuestion = new Question();
            CreateRedactQuestion questionWindow = new CreateRedactQuestion(newQuestion);
            questionWindow.Owner = this;
            this.Hide();
            if (questionWindow.ShowDialog() == true)
            {
                currentTest.questions.Add(newQuestion);
            }
            this.Show();
        }
    }
}
