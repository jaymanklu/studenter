using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class ExamTimeTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExamTimeTableID { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        [Required(ErrorMessage = "Please specify a date and a time for the exam"), Display(Name = "Exam Date and Time"), DataType(DataType.DateTime)]
        public DateTime SubjectTestTime { get; set; }

        public Guid ExamID { get; set; }

        [ForeignKey("ExamID")]
        public virtual Exam Exam { get; set; }
    }
}
