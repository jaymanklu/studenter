using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    //This class is for specifically exams. Use this in DB context for each student's exam result.
    public class StudentExamMarksResult : StudentGeneralMarksResult
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private Int32 StudentExamMarksResultID { get; set; }
    }
}
