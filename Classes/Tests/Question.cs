﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public abstract class Question
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Answer> Answers { get; } = new List<Answer>();
        protected Question(string name)
        {
            Name = name;
        }
        public abstract Page Show();
        public abstract Page ShowInRedactMode();
    }
}
