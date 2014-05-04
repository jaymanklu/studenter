using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Exam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ExamID { get; set; }

        [Required(ErrorMessage = "Specify a name to this Exam"), Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Specify Start Date of the Exam"), DataType(DataType.DateTime), Display(Name = "Start Date and Time of the Test")]
        public DateTime StartDateAndTime { get; set; }

        [Required(ErrorMessage = "Please Specify End Date of the Exam"), DataType(DataType.DateTime), Display(Name = "End Date and Time of the Test")]
        public DateTime EndDateAndTime { get; set; }

        public Int32 SectionID { get; set; }

        [ForeignKey("SectionID"), Display(Name = "Section")]
        public virtual GradeSection Section { get; set; }

        [Required(ErrorMessage = "Please enter the subjects on which test is given"), Display(Name = "Subjects")]
        public virtual ICollection<Subject> Subjects { get; set; }

        [Required(ErrorMessage = "Please enter the teachers handling exams"), Display(Name = "Exam Teachers")]
        public virtual ICollection<Teacher> Teachers { get; set; }

        [Display(Name="Marks Students Earned")]
        public virtual ICollection<ExamMatrix> MarksStudentsEarned { get; set; }

        [Display(Name="Total Marks")]
        public virtual ICollection<ExamTotalMarksMatrix> TotalMarks { get; set; }

        public virtual ICollection<ExamTimeTable> TimeTable { get; set; }

        public virtual ICollection<ExamStudentAggregation> StudentAggregation { get; set; }

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
