using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class MonthlyTest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MonthlyTestID { get; set; }

        [Required(ErrorMessage="Specify a name to this monthly test"), Display(Name="Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please Specify Start Date"), DataType(DataType.DateTime), Display(Name = "Start Date of the Test")]
        public DateTime StartDateAndTime { get; set; }

        [Required(ErrorMessage = "Please Specify End Date and Time"), DataType(DataType.DateTime), Display(Name = "End Date of the Test")]
        public DateTime EndDateAndTime { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("SectionID"), Display(Name = "Section")]
        public virtual GradeSection Section { get; set; }

        [Required(ErrorMessage = "Please enter the subjects on which test is given"), Display(Name = "Subjects")]
        public virtual ICollection<Subject> Subjects { get; set; }

        [Required(ErrorMessage = "Please enter the teachers who gave the tests"), Display(Name = "Test Teachers")]
        public virtual ICollection<Teacher> TestTeacher { get; set; }

        [Display(Name="Test Marks")]
        public virtual ICollection<MonthlyTestMatrix> MarksStudentsEarned { get; set; }

        [Display(Name="Total Marks")]
        public virtual ICollection<MonthlyTestTotalMarksMatrix> TotalMarks { get; set; }

        [Display(Name="Test Timetable")]
        public virtual ICollection<MonthlyTestTimeTable> TestTimeTable { get; set; }

        [Display(Name = "Student Marks Aggregation")]
        public virtual ICollection<MonthlyTestStudentAggregation> Aggregation { get; set; }

        [ForeignKey("CurrentSectionID")]
        public virtual SectionSubjectTeaching CurrentSection { get; set; }

        public Guid CurrentSectionID { get; set; }

        [Display(Name = "Passed Student Number")]
        public Int32? PassedStudentNumber { get; set; }

        [Display(Name = "Failed Student Number")]
        public Int32? FailedStudentNumber { get; set; }

        [Display(Name = "Pass Percentage")]
        public float? PassPercentage { get; set; }
    }
}
