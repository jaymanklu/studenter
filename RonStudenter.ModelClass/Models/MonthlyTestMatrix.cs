using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    public class MonthlyTestMatrix
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MonthlyTestMatrixID { get; set; }

        [Required(ErrorMessage = "Please specify the marks earned"), Display(Name = "Marks Earned")]
        public float? MarksEarned { get; set; }

        [Display(Name = "Grade Earned")]
        public string Grade { get; set; }

        [Required(ErrorMessage = "Please specify the total marks"), Display(Name = "Total Marks")]
        public float? TotalMarks { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public Guid MonthlyTestID { get; set; }

        [ForeignKey("MonthlyTestID")]
        public virtual MonthlyTest Test { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }
    }
}
