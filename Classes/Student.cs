using program_for_school_tests_ukr.Classes.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_for_school_tests_ukr.Classes
{
    public class Student : User
    {
        public List<Mark> Marks { get; } = new List<Mark>();

        //класс

        //коментарі про учня, від інших вчителів

        //можливо якась додаткова інформація

        public override string ToString()
        {
            return "Student";
        }
    }
}
