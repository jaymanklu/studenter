using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class AttendanceSatisfied
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AttendanceSatisfiedID { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("SectionID")]
        public virtual GradeSection Section { get; set; }

        public Int32 SubjectID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        [Required, Display(Name = "Attendence Requirement Satisfied")]
        public Boolean RequirementSatisfied { get; set; }
    }
}
