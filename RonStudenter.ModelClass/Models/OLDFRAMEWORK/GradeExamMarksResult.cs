﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary.OldFramework
{
    //DO NOT USE - NOT IN DB CONTEXT
    public class GradeExamMarksResult
    {
        public Int32 GradeExamMarksResultID { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual IList<GradeSectionExamMarksResult> AllSectionResults { get; set; }
        public Int32 PassStudentNumber { get; set; }
        public Int32 FailStudentNumber { get; set; }
        public float PassPercentage { get; set; }
    }
}
