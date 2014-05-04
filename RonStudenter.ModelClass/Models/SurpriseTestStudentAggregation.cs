using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class SurpriseTestStudentAggregation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ResultID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public string StudentID { get; set; }

        public virtual ICollection<SurpriseTest> SurpriseTestsForAggregation { get; set; }

        [Display(Name = "Total Marks Student Earned")]
        public float? TotalMarks { get; set; }

        [Display(Name = "Total Grade Student Earned")]
        public string TotalGrade { get; set; }

        [Display(Name = "Percentage")]
        public float? Percentage { get; set; }

        [Display(Name = "Student Rank")]
        public Int32? StudentRank { get; set; }
    }
}
