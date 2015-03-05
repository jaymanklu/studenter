using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.MVCWeb.ViewModels
{
    public class StudentEntityViewModel
    {
        public Student Student { get; set; }
        public Address Address { get; set; }
        public Parent Parent { get; set; }
        public GradeSection GradeSection { get; set; }

    }
}