using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InRonStudenter.ModelLibrary
{
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }

        [Required(ErrorMessage = "Please provide a name for the Project"), Display(Name = "Project Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a Project Description"), Display(Name = "Project Description")]
        public string Description { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<GradeSection> SectionsInvolved { get; set; }

        public virtual ICollection<Grade> GradesInvolved { get; set; }

        public virtual ICollection<Student> StudentsInvolved { get; set; }

        public virtual ICollection<Teacher> TeachersInvolved { get; set; }


    }
}
