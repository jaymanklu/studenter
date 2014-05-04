using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class NonTeachingFaculty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid NonTeachingFacultyID { get; set; }

        [Display(Name = "Person ID")]
        public string PersonID { get; set; }

        [Required(ErrorMessage = "Please enter a Name"), Display(Name = "Name")]
        public string Name { get; set; }

        public string Photo { get; set; }

        [ForeignKey("DeptID")]
        public virtual TeachingDepartment Department { get; set; }

        public string DeptID { get; set; }

        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public Guid AddressID { get; set; }
    }
}
