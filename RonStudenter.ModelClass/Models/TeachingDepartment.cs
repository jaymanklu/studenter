using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class TeachingDepartment
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<NonTeachingFaculty> NonTeachingStaff { get; set; }

        [ForeignKey("HeadID")]
        public virtual Teacher DepartmentHead { get; set; }

        public Guid HeadID { get; set; }

    }
}
