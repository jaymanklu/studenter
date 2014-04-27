using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //In DB Context, for surprise tests and stuff
    public class StudentInformalTestMarksResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name="Marks ID")]
        public Int32 StudentInformalTestMarksResultID { get; set; }

        [Display(Name="Marks")]
        public IDictionary<Int16, float> Marks { get; set; }

        [Display(Name="Student")]
        public virtual Student Student { get; set; }

        [Display(Name = "Passed?")]
        public IDictionary<Int16, Boolean> Passed { get; set; }

        //Using schoolattributes for passing marks results
        private virtual SchoolAttributes SchoolAttributesForPassingMarks { get; set; }

        [Display(Name="Total Marks for the test")]
        public IDictionary<Int16, float> TotalMarks { get; set; }

        [Display(Name = "Passing Marks for the test")]
        public IDictionary<Int16, float> PassingMarks { get; set; } 
    }
}
