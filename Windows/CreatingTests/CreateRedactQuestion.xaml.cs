﻿using program_for_school_tests_ukr.Classes.Tests;
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
    /// Interaction logic for CreateRedactQuestion.xaml
    /// </summary>
    public partial class CreateRedactQuestion : Window
    {
        Question currentQuestion;
        public CreateRedactQuestion(Question currentQuestion)
        {
            this.currentQuestion = currentQuestion;
            InitializeComponent();
        }

        private void SaveAndExitButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: перевірка на нульові значення
            this.DialogResult = true;
            this.Close();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            DataContext = currentQuestion;
        }

        private void AddNewAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            currentQuestion.Answers.Add(new Answer());
            listOfAnswers.Items.Refresh();
        }
    }
}
