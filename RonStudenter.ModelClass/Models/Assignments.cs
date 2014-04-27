using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Parent class. DO NOT put to DBContext
    public class Assignments
    {
        [Display(Name = "Students doing the Assignment")]
        public virtual IList<Student> InvolvedStudents { get; set; }

        [Display(Name = "Assignment Teachers")]
        public virtual IList<Teacher> Teachers { get; set; }

        [Required, Display(Name="Assignment Given Date"), DataType(DataType.DateTime)]
        public DateTime AssignedDate { get; set; }

        [Required(ErrorMessage="Please enter Date on which students have to submit assignments"), DataType(DataType.DateTime), Display(Name="Assignment Submission Date")]
        public DateTime SubmitDate { get; set; }

        [Display(Name = "Students Submitted Assignments")]
        public IDictionary<Int32, Boolean> SubmittedStudents { get; set; }

        [Display(Name = "Marks Awarded")]
        public IDictionary<Int32, float> MarksAwarded { get; set; }

        [Display(Name = "Grade Awarded")]
        public IDictionary<Int32, String> GradeAwarded { get; set; }
    }
}
