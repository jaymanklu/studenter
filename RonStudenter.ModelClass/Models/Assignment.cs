using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Parent class. DO NOT put to DBContext
    public class Assignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 AssigmentID { get; set; }

        public string Name { get; set; }


        public string Description { get; set; }

        [Display(Name = "Students doing the Assignment")]
        public virtual ICollection<Student> InvolvedStudents { get; set; }

        [Display(Name = "Assignment Teachers")]
        public virtual ICollection<Teacher> Teachers { get; set; }

        [Required, Display(Name="Assignment Given Date"), DataType(DataType.DateTime)]
        public DateTime AssignedDate { get; set; }

        [Required(ErrorMessage="Please enter Date on which students have to submit assignments"), DataType(DataType.DateTime), Display(Name="Assignment Submission Date")]
        public DateTime SubmitDate { get; set; }

        [Display(Name = "Students Submitted Assignments")]
        public virtual ICollection<BooleanTableStudentAssignmentSubmitted> SubmittedStudents { get; set; }

        public virtual Subject { get; set; }

        [Display(Name = "Grade Awarded")]
        public ICollection<AssignmentGradeAwarded> GradeAwarded { get; set; }
    }
}
