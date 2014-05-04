using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InRonStudenter.ModelLibrary
{
    public class TeacherLessonPlan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LessonPlanID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }

        public Guid TeacherID { get; set; }

        [Display(Name = "Lessson Plan")]
        public string LessonPlan { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("CurrentSubjectID")]
        public virtual SectionSubjectTeaching TeachingMetadata { get; set; }

        public Guid CurrentSubjectID { get; set; }
    }
}
