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
        public Int16 TimeTableID { get; set; }

        [Display(Name = "Section")]
        public virtual GradeSection GradeSection { get; set; }

        //To be filled by controller
        [Required, Display(Name="Time Table")]
        public IDictionary<IDictionary<String, String>, IDictionary<String, String>> TimeTableMatrix { get; set; }
    }
}
