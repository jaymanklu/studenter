using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InRonStudenter.ModelLibrary
{
    public class TimeTableMatrix
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }

        public Guid TeacherID { get; set; }

        [Display(Name = "Additional Info")]
        public string Remarks { get; set; }

        [Required, Display(Name = "Day")]
        public Days Day { get; set; }

        [Required, Display(Name = "Time")]
        public ClassTimes Time { get; set; }




    }
}
