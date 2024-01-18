using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace program_for_school_tests_ukr.Classes.Converters
{
    [ValueConversion(typeof(Answer), typeof(bool), ParameterType = typeof(Answer))]
    internal class IsCheckedToActualAnswerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = (Answer)value;
            return answer.Equals(answer.AnswerToQuestion.ActualAnswer);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            var answer = (Answer)parameter;

            if (isChecked)
            {
                return answer;
            }
            return answer.AnswerToQuestion.ActualAnswer!;
        }
    }
}
