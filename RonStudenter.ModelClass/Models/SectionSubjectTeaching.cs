using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InRonStudenter.ModelLibrary
{
    public class SectionSubjectTeaching
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TeachingID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }

        public virtual ICollection<Teacher> SubjectTeachers { get; set; }

        public virtual ICollection<TeacherLessonPlan> LessonPlan { get; set; }

        public virtual ICollection<SectionLevelAssignments> Assignments { get; set; }

        public virtual ICollection<SurpriseTest> SurpriseTests { get; set; }

        public virtual ICollection<MonthlyTest> MonthlyTests { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
