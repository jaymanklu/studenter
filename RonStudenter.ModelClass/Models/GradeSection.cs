using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InRonStudenter.ModelLibrary
{
    //Model for storing Section information in DB context, controller will be scaffolded
    public class GradeSection
    {
        public Int32 GradeSectionID { get; set; }

        [Required(ErrorMessage="Please enter the class / grade to which this section belongs to"), Display(Name="Class / Grade name")]
        public String Name { get; set; }

        [Display(Name="List of Students in this section")]
        public virtual IList<Student> Students { get; set; }

        [Display(Name="List of Teachers for this section")]
        public virtual IList<Teacher> Teachers { get; set; }

        [Required(ErrorMessage="Please choose a class teacher"), Display(Name="Class Teacher")]
        public virtual Teacher ClassTeacher { get; set; }

        [Display(Name = "Section Time Table")]
        public virtual TimeTable TimeTable { get; set; }

        [Display(Name = "Section Test Results")]
        public virtual IList<TestResult> TestResults { get; set; }

        [Display(Name = "Section Exam Results")]
        public virtual IList<GradeSectionExamMarksResult> ExamResults { get; set; }

        [Display(Name = "Section Projects")]
        public virtual IList<Project> Projects { get; set; }

        [Display(Name = "Section Projects")]
        public virtual IList<StudentExtraCurricular> ExtraCurriculars { get; set; }

        [Display(Name = "Section Events")]
        public virtual IList<Event> Events { get; set; }

        [Display(Name="Section Classroom")]
        public string Classroom { get; set; }

        [Display(Name = "Attendance Matrix")]
        //Attendance Subject -> Student -> Date - Attended or not = ENUM to be used for DateTime
        public IDictionary<String, IDictionary<Int32, IDictionary<DateTime, Boolean>>> AttendanceMartix { get; set; }

        public virtual SchoolAttributes SchoolAttributes { get; set; }

        [Display(Name = "Minimum Attendance Satisfied")]
        public IDictionary<String, IDictionary<Int32, Boolean>> AttendanceRequirementMartix { get; set; }

    }
}
