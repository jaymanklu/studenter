using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    public class ExamMatrix
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExamMatrixID { get; set; }

        [Required(ErrorMessage = "Please specify the marks earned"), Display(Name = "Marks Earned")]
        public float? MarksEarned { get; set; }

        [Display(Name = "Grade Earned")]
        public String? Grade { get; set; }

        [Required(ErrorMessage = "Please specify the total marks"), Display(Name = "Total Marks")]
        public float? TotalMarks { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public Int32 ExamID { get; set; }

        [ForeignKey("ExamID")]
        public virtual Exam Exam { get; set; }
    }
}
