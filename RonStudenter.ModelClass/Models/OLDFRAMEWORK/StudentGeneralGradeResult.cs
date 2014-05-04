using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary.OldFramework
{
    //DONT USE - NOT IN DB CONTEXT
    public class StudentGeneralGradeResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int32 StudentGeneralGradeResultID { get; set; }

        public virtual Student Student { get; set; }

        //We wont let people fill this matrix directly
        [Display(Name="Marks")]
        public IDictionary<Int16, float> SubjectMarksMatrix { get; set; }
        
        [Display(Name = "Grades")]
        public IDictionary<Int16, string> SubjectGradeMatrix { get; set; }

        //We wont let people fill this matrix directly
        [Display(Name="Passed?")]
        public IDictionary<Int16, Boolean> SubjectPassMatrix { get; set; }

        //Using schoolattributes for passing marks and total marks results
        public virtual SchoolAttributes SchoolAttributesForPassingAndTotalMarks { get; set; }

        //Filled by logic
        [Display(Name="Total Marks")]
        public float TotalMarks { get; set; }

        [Display(Name = "GPA")]
        public float GPA { get; set; }

        [Display(Name="Student Rank")]
        public UInt16 Rank { get; set; }
    }
}
