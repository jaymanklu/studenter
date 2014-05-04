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
    public class MonthlyTestTotalMarksMatrix
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MonthlyTestTotalMarksMatrixID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("MonthlyTestID")]
        public virtual MonthlyTest MonthlyTest { get; set; }

        public Guid MonthlyTestID { get; set; }

        [Display(Name="Total Marks")]
        public float? TotalMarks { get; set; }
    }
}
