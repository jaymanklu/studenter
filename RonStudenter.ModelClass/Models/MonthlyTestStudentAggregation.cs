﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InRonStudenter.ModelLibrary
{
    //THIS TAKES CARE OF YOUR TOTAL MARKS RANKS AND STUFF FOR EACH STUDENT ATTENDED THE MONTHLY TEST
    public class MonthlyTestStudentAggregation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ResultID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("MonthlyTestID")]
        public virtual MonthlyTest MonthlyTest { get; set; }

        public Guid MonthlyTestID { get; set; }

        [Display(Name="Total Marks Student Earned")]
        public float? TotalMarks { get; set; }

        [Display(Name = "Total Grade Student Earned")]
        public string TotalGrade { get; set; }

        [Display(Name = "Percentage")]
        public float? Percentage { get; set; }

        [Display(Name = "Student Rank")]
        public Int32? StudentRank { get; set; }

    }

}
