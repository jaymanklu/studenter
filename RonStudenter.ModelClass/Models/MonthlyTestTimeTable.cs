using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    public class MonthlyTestTimeTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MonthlyTestTimeTableID { get; set; }

        public string SubjectID { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject Subject { get; set; }
        
        [Required(ErrorMessage="Please specify a date and a time for the test"), Display(Name="Test Date and Time"), DataType(DataType.DateTime)]
        public DateTime SubjectTestTime { get; set; }

        public Guid MonthlyTestID { get; set; }

        [ForeignKey("MonthlyTestID")]
        public virtual MonthlyTest Test { get; set; }
    }
}
