using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public interface IAnswerControl
    {
        public UserControl UserControl { get; protected set; }
        public bool IsChecked { get; set; }
    }

    public abstract class Answer
    {
        public int Id { get; private set; }
        [NotMapped]
        public IAnswerControl? AnswerControl { get; private set; }
        public abstract UserControl Show();
        public abstract UserControl ShowInRedactMode();
    }

    public class TextAnswer : Answer
    {
        [Unicode(true)]
        [MaxLength(256)]
        public string Text { get; set; }

        public TextAnswer(string text)
        {
            Text = text;
        }

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
        public byte[]? Picture { get; protected set; }
        protected virtual System.Drawing.Image? GetImageFromArray()
        {
            if (Picture == null) return null;
            using (var ms = new MemoryStream(Picture))
            {
                var returnImage = System.Drawing.Image.FromStream(ms);

                return returnImage;
            }
        }

        public virtual void SavePicture(System.Drawing.Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Picture = ms.ToArray();
        }
        public override UserControl Show()
        {
            throw new NotImplementedException();
        }

        public override UserControl ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }

    public class OpenAnswer : Answer
    {
        [Unicode]
        [MaxLength(100)]
        public string? Text { get; set; }

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
