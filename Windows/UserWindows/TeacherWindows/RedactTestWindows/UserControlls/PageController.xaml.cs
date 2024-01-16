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
          propertyType: typeof(IEnumerable<Question>),
          ownerType: typeof(PageController),
          typeMetadata: new FrameworkPropertyMetadata()
        );
        public IEnumerable<Question> ListOfQuestions
        {
            get => (IEnumerable<Question>) GetValue(QuestionsProperty);
            set => SetValue(QuestionsProperty, value);
        }

        public static readonly DependencyProperty PageWindowProperty = DependencyProperty.Register(
            "PageWindow", typeof(Control),
            typeof(PageController)
            );

        public Control PageWindow
        {
            get => (Control)GetValue(PageWindowProperty);
            set => SetValue(PageWindowProperty, value);
        }
        public PageController()
        {
            InitializeComponent();
        }

        private void PageController_Loaded(object sender, RoutedEventArgs e)
        {
            if (QuestionsPropertyKey == null)
                throw new ArgumentNullException(nameof(QuestionsPropertyKey));
            if (PageWindowProperty == null)
                throw new ArgumentNullException(nameof(PageWindow));
        }
    }
}
