﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InRonStudenter.ModelLibrary
{
    //Student. In DB Context
    public class Student
    {
        public String StudentID { get; set; }

        [Required(ErrorMessage = "Please provide a Student Name"), Display(Name = "Student Name")]
        public String Name { get; set; }

        public string Photo { get; set; }

        public Guid AddressID { get; set; }

        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public virtual ICollection<Parent> Parents { get; set; }

        public virtual ICollection<SurpriseTestMatrix> SurpriseTestsGiven { get; set; }

        public virtual ICollection<ExamMatrix> ExamsGiven { get; set; }

        public virtual ICollection<MonthlyTestMatrix> TestsGiven { get; set; }

        [ForeignKey("SectionID")]
        public virtual GradeSection Section { get; set; }

        public Int32 SectionID { get; set; }
    }
}
