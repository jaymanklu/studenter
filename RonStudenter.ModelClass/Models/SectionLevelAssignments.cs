using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Section Level Assignments. In DB Context
    public class SectionLevelAssignments : Assignment
    {
        public Int32 SectionLevelAssignmentsID { get; set; }

        [ForeignKey("SectionID")]
        public virtual GradeSection Section { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("TeachingID")]
        public virtual SectionSubjectTeaching CurrentSectionSubject { get; set; }

        public Guid TeachingID { get; set; }

    }
}
