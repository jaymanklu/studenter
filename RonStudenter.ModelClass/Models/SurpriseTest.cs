using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InRonStudenter.ModelLibrary
{
    //Abstraction for the test. no separate controller. will be part of a MVVM
    public class SurpriseTest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SurpriseTestID { get; set; }

        [Required(ErrorMessage="Specify a name to this surprise test"), Display(Name="Name")]
        public String Name { get; set; }

        [Required(ErrorMessage="Please Specify Date and Time when Surprise Test was held"), DataType(DataType.DateTime), Display(Name="Date and Time of the Test")]
        public DateTime DateAndTime { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("SectionID"), Display(Name="Section")]
        public virtual GradeSection Section { get; set; }

        [Required(ErrorMessage = "Please specify the total marks"), Display(Name = "Total Marks")]
        public float? TotalMarks { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("SubjectID"), Required(ErrorMessage="Please enter the subject on which test was given"), Display(Name="Subject")]
        public virtual Subject Subject { get; set; }

        [Required(ErrorMessage = "Please enter the teachers who gave the tests"), Display(Name = "Test Teachers")]
        public virtual ICollection<Teacher> TestTeacher { get; set; }

        public virtual ICollection<SurpriseTestMatrix> MarksStudentsEarned { get; set; }
    }
}
