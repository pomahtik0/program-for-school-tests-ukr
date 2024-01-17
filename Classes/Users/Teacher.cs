using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_for_school_tests_ukr.Classes.Users
{
    public class Teacher : User
    {
        public virtual ObservableCollection<TestInfo> OwnedTests { get; } = [];

        public override Window GetWindow()
        {
            throw new NotImplementedException();
        }
    }
}
