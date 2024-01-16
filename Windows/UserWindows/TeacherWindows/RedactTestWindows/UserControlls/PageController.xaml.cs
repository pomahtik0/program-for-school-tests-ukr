using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace program_for_school_tests_ukr.Windows.UserWindows.TeacherWindows.RedactTestWindows.UserControlls
{
    /// <summary>
    /// Interaction logic for PageController.xaml
    /// </summary>
    public partial class PageController : UserControl
    {
        private static readonly DependencyProperty QuestionsProperty =
        DependencyProperty.Register(
          name: "ListOfQuestions",
          propertyType: typeof(ObservableCollection<Question>),
          ownerType: typeof(PageController),
          typeMetadata: new FrameworkPropertyMetadata(defaultValue: new ObservableCollection<Question>())
        );
        public ObservableCollection<Question> ListOfQuestions
        {
            get => (ObservableCollection<Question>) GetValue(QuestionsProperty);
            set => SetValue(QuestionsProperty, value);
        }

        public static readonly DependencyProperty PageWindowProperty = DependencyProperty.Register(
            "PageWindow", typeof(Control),
            typeof(PageController)
            );

        public Frame PageWindow
        {
            get => (Frame)GetValue(PageWindowProperty);
            set => SetValue(PageWindowProperty, value);
        }
        public PageController()
        {
            InitializeComponent();
        }

        private void PageController_Loaded(object sender, RoutedEventArgs e)
        {
            wrapper.Children.Clear();
            int i = 1;
            foreach(Question question in ListOfQuestions)
            {
                Button button = new Button();
                button.Content = i++.ToString();
                button.Click += (s, e) =>
                {
                    PageWindow.Content = question.ShowInRedactMode();
                };
                wrapper.Children.Add(button);
            }
            Button addButton = new Button();
            addButton.Content = "+";
            addButton.Click += (s, e) =>
            {
                var question = addNewQuestion();
                ListOfQuestions.Add(question);
                PageWindow.Content = question.ShowInRedactMode();
            };
            wrapper.Children.Add(addButton);
        }

        private Question addNewQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
