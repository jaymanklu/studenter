using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Parent
    {
        public Int32 ParentID { get; set; }
        [Required(ErrorMessage = "Please provide parents name")]
        [Display(Name= "Parent / Guardian Name")]
        public String ParentName { get; set; }
        [Required(ErrorMessage = "Please Specify"), Display(Name="Relation")]
        public UInt16 ParentRelation { get; set; }
        [Display(Name="Is the person Guardian?")]
        public Boolean IsGuardian { get; set; }
        public String ParentOccupation { get; set; }
        [Required(ErrorMessage="Please provide contact number"), Display(Name="Contact Number")]
        public String ParentContactNumber { get; set; }
        public Address ParentAddress { get; set; }
        public virtual IList<Student> ParentOf { get; set; }
    }
}
