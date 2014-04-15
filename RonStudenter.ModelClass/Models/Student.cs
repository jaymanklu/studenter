using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InRonStudenter.ModelLibrary
{

    public class Student
    {
        public String StudentID { get; set; }
        [Required(ErrorMessage = "Please provide a Student Name"), Display(Name = "Student Name")]
        public String StudentName { get; set; }
        public Address StudentAddress { get; set; }
        public virtual IList<Parent> Parents { get; set; }
    }
}
