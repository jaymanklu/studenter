using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.ModelLibrary
{
    // A Grade sections exam result. In DB context
    public class GradeSectionExamMarksResult
    {
        public Int32 GradeSectionExamMarksResultID { get; set; }
        public virtual IList<StudentExamMarksResult> StudentResults { get; set; }
        public virtual GradeSection GradeSection { get; set; }
    }
}
