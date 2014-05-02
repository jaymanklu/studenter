using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InRonStudenter.ModelLibrary
{
    //Table to store when assignments are done or otherwise
    public class BooleanTableStudentAssignmentSubmitted
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BooleanTableStudentAssignmentSubmittedID { get; set; }

        public String StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student AssignmentStudent { get; set; }

        public Int32 AssignmentID { get; set; }

        [ForeignKey("AssignmentID")]
        public virtual Assignment Assignment { get; set; }

        [Required(ErrorMessage="Please Enter where Student Finished Assignment"), Display(Name="Done?")]
        public Boolean Done { get; set; }
    }
}
