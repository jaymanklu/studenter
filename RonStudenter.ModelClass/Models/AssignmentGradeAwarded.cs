using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Table to assignment of grades to the student for his assignment
    public class AssignmentGradeAwarded
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AssignmentGradeAwardedID { get; set; }

        public String StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student AssignmentStudent { get; set; }

        public Int32 AssignmentID { get; set; }

        [ForeignKey("AssignmentID")]
        public virtual Assignment Assignment { get; set; }

        [Display(Name = "Grade Awarded")]
        public string? GradeAwarded { get; set; }

        [Display(Name = "Marks Awarded")]
        public float? MarksAwarded { get; set; }


    }
}
