using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary.OldFramework
{
    //DONT USE - NOT IN DB CONTEXT
    public class StudentTestGradeResult : StudentGeneralGradeResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int32 StudentTestMarksResultID { get; set; }
    }
}
