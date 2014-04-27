using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Section Level Assignments. In DB Context
    public class SectionLevelAssignments : Assignments
    {
        public Int32 SectionLevelAssignmentsID { get; set; }

        [Display(Name = "Assignment assigned to Section")]
        public virtual GradeSection GradeSection { get; set; }

    }
}
