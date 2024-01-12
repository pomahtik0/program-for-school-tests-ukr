using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public abstract class Answer
    {
        public int Id { get; set; }
        public abstract UserControl Show();
        public abstract UserControl ShowInRedactMode();
    }

    public class TextAnswer : Answer
    {
        public string Text { get; set; }

        public override UserControl Show()
        {
            throw new NotImplementedException();
        }

        public override UserControl ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }

    public class PictureAnswer : Answer
    {
        public byte[] Picture { get; set; }
        public override UserControl Show()
        {
            throw new NotImplementedException();
        }

        public override UserControl ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }
}
