using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    //General Template for test / exam or any other exam. Derive from this. NOT in DBcontext
    public class StudentGeneralMarksResult
    {

        public virtual Student Student { get; set; }

        //We wont let people fill this matrix directly
        [Display(Name="Marks of all Subjects")]
        public IDictionary<Int16, float> SubjectMarksMatrix { get; set; }

        //We wont let people fill this matrix directly
        [Display(Name="Passed?")]
        public IDictionary<Int16, Boolean> SubjectPassMatrix { get; set; }

        //Using schoolattributes for passing marks results and total marks
        public virtual SchoolAttributes SchoolAttributesForPassingMarksAndTotalMarks { get; set; }

        //Filled by logic
        [Display(Name="Total Marks")]
        public float TotalMarks { get; set; }

        [Display(Name = "Percentage")]
        public float Percentage { get; set; }

        [Display(Name="Student Rank")]
        public UInt16 Rank { get; set; }
    }
}
