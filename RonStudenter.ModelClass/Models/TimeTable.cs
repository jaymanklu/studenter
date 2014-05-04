using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //Model for all sections timetables. will be in DB context and also a controller will be scaffolded but with custom controls
    public class TimeTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name="Time Table ID")]
        public Guid TimeTableID { get; set; }

        [ForeignKey("SectionID")]
        public virtual GradeSection GradeSection { get; set; }

        public Int32 SectionID { get; set; }

        public virtual ICollection<TimeTableMatrix> TimeTableInfo { get; set; }
    }
}
