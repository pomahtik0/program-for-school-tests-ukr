using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace program_for_school_tests_ukr.Classes.Tests
{
    public abstract class Question
    {
        public int Id { get; private set; }
        [Unicode]
        [MaxLength(50)]
        public string Name { get; set; } = "";
        public List<Answer> Answers { get; } = [];
        public Answer? ActualAnswer { get; set; }
        [NotMapped]
        public Page? QuestionPage { get; private set; }
        public abstract Page Show();
        public abstract Page ShowInRedactMode();
    }

    public class QuestionAsText : Question
    {
        [Unicode]
        [MaxLength(256)]
        [Column("Text")]
        public string Text { get; set; } = "";
        public override Page Show()
        {
            throw new NotImplementedException();
        }
        public override Page ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }

    public class QuestionAsPicture : Question
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
        public override Page Show()
        {
            throw new NotImplementedException();
        }
        public override Page ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }

    public class QuestionAsPictureAndText : QuestionAsPicture
    {
        [Unicode]
        [MaxLength(256)]
        [Column("Text")]
        public string Text { get; set; } = "";
        public override Page Show()
        {
            throw new NotImplementedException();
        }
        public override Page ShowInRedactMode()
        {
            throw new NotImplementedException();
        }
    }
}
