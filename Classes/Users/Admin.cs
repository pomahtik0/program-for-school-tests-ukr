using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_for_school_tests_ukr.Classes.Users
{
    // відповідальний за реєстрацію нових вчителів, і очищення історії оцінок якщо потрібно.
    public class Admin : User
    {
        public override Window GetWindow()
        {
            throw new NotImplementedException();
        }
    }
}
