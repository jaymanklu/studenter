using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InRonStudenter.ModelLibrary
{
    public class Teacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TeacherDBID { get; set; }

        [Required(ErrorMessage = "Please Enter an ID for Teacher"), Display(Name = "Teacher ID")]
        public string TeacherID { get; set; }

        [Required(ErrorMessage = "Please Enter an name for Teacher"), Display(Name = "Teacher Name")]
        public string Name { get; set; }

        public string Photo { get; set; }

        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public Guid AddressID { get; set; }

        [Display(Name = "Subjects Handled")]
        public string SubjectsHandled { get; set; }

        [ForeignKey("DeptID")]
        public virtual TeachingDepartment Department { get; set; }

        public string DeptID { get; set; }

        [Display(Name = "Qualifications")]
        public string Qualifications { get; set; }

        [Display(Name = "Awards Recieved")]
        public string Awards { get; set; }

        [Display(Name = "Appraisals Recieved")]
        public string Appraisals { get; set; }


    }
}
