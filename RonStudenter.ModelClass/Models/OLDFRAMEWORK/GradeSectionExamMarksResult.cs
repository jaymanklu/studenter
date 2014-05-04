using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.ModelLibrary.OldFramework
{
    // //DO NOT USE - NOT IN DB CONTEXT
    public class GradeSectionExamMarksResult
    {
        public Int32 GradeSectionExamMarksResultID { get; set; }
        public virtual IList<StudentExamMarksResult> StudentResults { get; set; }
        public virtual GradeSection GradeSection { get; set; }
    }
}
