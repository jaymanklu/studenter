using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Class level assignments. In DB Context
    public class GradeLevelAssignments : Assignment
    {
        public Int32 GradeLevelAssignmentsID { get; set; }

        [Display(Name = "Assignment assigned to Grade / Class")]
        public virtual Grade Grade { get; set; }

    }
}
