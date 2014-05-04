using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //In DB Context contains the total marks for a subject for a exam
    public class ExamTotalMarksMatrix
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExamTotalMarksMatrixID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("ExamID")]
        public virtual Exam Exam { get; set; }

        public Int32 ExamID { get; set; }

        [Display(Name="Total Marks")]
        public float? TotalMarks { get; set; }
    }
}
