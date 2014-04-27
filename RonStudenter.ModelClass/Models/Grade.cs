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
        public virtual IList<GradeSection> Sections { get; set; }

        [Display(Name = "Class / Grade Projects")]
        public virtual IList<Project> Projects { get; set; }

    }
}
