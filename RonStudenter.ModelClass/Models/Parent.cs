using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{

    public enum ParentRelation { Parent, Guardian };
    public class Parent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ParentID { get; set; }

        [Required(ErrorMessage = "Please provide parents name")]
        [Display(Name= "Parent / Guardian Name")]
        public String Name { get; set; }
        
        [Required(ErrorMessage = "Please Specify"), Display(Name="Relation")]
        public ParentRelation Relation { get; set; }

        public String Occupation { get; set; }

        [Required(ErrorMessage="Please provide contact number"), Display(Name="Contact Number")]
        public String ContactNumber { get; set; }

        public Guid AddressID { get; set; }

        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public virtual ICollection<Student> ParentOf { get; set; }
    }
}
