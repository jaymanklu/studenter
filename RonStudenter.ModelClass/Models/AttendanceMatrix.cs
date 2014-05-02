using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InRonStudenter.ModelLibrary
{
    //Attendance Table making it attached to student gradesection and wherever applicable
    public class AttendanceMatrix
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AttendanceMatrixID { get; set; }

        [Required, Display(Name="Class Date and Time")]
        public DateTime ClassDateTime { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("SectionID")]
        public virtual GradeSection Section { get; set; }

        public Int32 SubjectID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        [Required(ErrorMessage="Please Mark whether student attended or not"), Display(Name="Attendence")]
        public Boolean Attended { get; set; }
    }
}
