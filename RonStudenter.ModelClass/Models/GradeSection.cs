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
        public virtual ICollection<Student> Students { get; set; }

        [Display(Name="List of Teachers for this section")]
        public virtual ICollection<Teacher> Teachers { get; set; }

        [Required(ErrorMessage="Please choose a class teacher"), Display(Name="Class Teacher")]
        public virtual Teacher ClassTeacher { get; set; }

        [Display(Name = "Section Time Table")]
        public virtual TimeTable TimeTable { get; set; }

        [Display(Name = "Surprise Tests Given")]
        public virtual ICollection<SurpriseTest> SurpriseTests { get; set; }

        [Display(Name = "Monthly Tests Given")]
        public virtual ICollection<MonthlyTest> MonthlyTests { get; set; }

        [Display(Name = "Exams Given")]
        public virtual ICollection<Exam> Exams { get; set; }

        [Display(Name = "Section Projects")]
        public virtual ICollection<Project> Projects { get; set; }

        [Display(Name = "Section Projects")]
        public virtual ICollection<StudentExtraCurricular> ExtraCurriculars { get; set; }

        [Display(Name = "Section Events")]
        public virtual ICollection<Event> Events { get; set; }

        [Display(Name="Section Classroom")]
        public string Classroom { get; set; }

        [Display(Name = "Attendance Book")]
        public ICollection<AttendanceMatrix> AttendanceBook { get; set; }

        public virtual SchoolAttributes SchoolAttributes { get; set; }

        [Display(Name = "Minimum Attendance Satisfied")]
        public ICollection<AttendanceSatisfied> SatisfiedBook { get; set; }
        

    }
}
