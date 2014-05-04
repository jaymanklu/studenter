using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary.OldFramework
{
    //DO NOT USE - NOT IN DB CONTEXT
    public class StudentTestMarksResult : StudentGeneralMarksResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int32 StudentTestMarksResultID { get; set; }
    }
}
