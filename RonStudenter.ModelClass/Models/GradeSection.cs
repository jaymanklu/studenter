using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InRonStudenter.ModelLibrary
{

    public class GradeSection
    {
        public Int32 GradeSectionID { get; set; }
        public String ClassGrade { get; set; }
        public virtual IList<Student> Students { get; set; }
        public virtual IList<Teacher> Teachers { get; set; }
        public virtual Teacher ClassTeacher { get; set; }
        public virtual TimeTable GradeTimeTable { get; set; }
        public virtual IList<TestResult> TestResults { get; set; }
        public virtual IList<ExamResult> ExamResults { get; set; }
        public virtual IList<Project> SectionProjects { get; set; }
        public virtual IList<ExtraCurricular> SectionExtraCurriculars { get; set; }
        public virtual IList<Event> SectionEvents { get; set; }


    }
}
