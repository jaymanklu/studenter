using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Subject
    {
        public string SubjectID { get; set; }

        [Required(ErrorMessage="Please enter the subject name"), Display(Name="Subject Name")]
        public string Name { get; set; }

        [Display(Name = "Subject Code")]
        public string Code { get; set; }

        

    }
}
