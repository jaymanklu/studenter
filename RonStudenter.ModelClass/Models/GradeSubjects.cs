using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.ModelLibrary
{
    public class GradeSubjects
    {
        private Int16 GradeSubjectsID { get; set; }

        [Display(Name = "Grade")]
        public virtual Grade Grade { get; set; }

        [Display(Name = "List of Subjects for a Grade")]
        public virtual IList<Subject> Subjects { get; set; }

        [Display(Name = "Subject - Teacher List")]
        public IDictionary<Int16, IList<string>> TeacherSubjectMatrix { get; set; }

        [Display(Name = "Student Test Marks")]
        public IDictionary<Int16 ,IDictionary<Int32, IList<float>>> StudentTestMarks { get; set; }

        [Display(Name = "Student Exam Marks")]
        public IDictionary<Int16, IDictionary<Int32, IList<float>>> StudentExamMarks { get; set; }

    }
}
