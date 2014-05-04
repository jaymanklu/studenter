using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    //Class for grade information, hierarchical information linking to grade sections
    public class Grade
    {
        public Int32 GradeID { get; set; }

        [Display(Name = "Class / Grade Sections")]
        public virtual ICollection<GradeSection> Sections { get; set; }

        [Display(Name = "Class / Grade Projects")]
        public virtual ICollection<Project> Projects { get; set; }

        [Display(Name = "Assignments given to this grade")]
        public virtual ICollection<GradeLevelAssignments> Assignments { get; set; }

        [Display(Name = "Grade level Extra Curricular")]
        public virtual ICollection<StudentExtraCurricular> ExtraCurricular { get; set; }

    }
}
