using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    //Model for extracuricular activity logging. Goes to context
    public class StudentExtraCurricular
    {
        public Int32 StudentExtraCurricularID { get; set; }

        [Required(ErrorMessage="Please select the list of students involved"), Display(Name="Student List")]
        public virtual IList<Student> Students { get; set; }

        //revision need to correct the flow of have subjects and marks or other way to represent
    }
}
