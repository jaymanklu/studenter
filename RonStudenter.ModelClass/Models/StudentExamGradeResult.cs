using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class StudentExamGradeResult : StudentGeneralGradeResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int32 StudentExamGradeResultID { get; set; }
    }
}
