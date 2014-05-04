using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace InRonStudenter.ModelLibrary
{
    //Table to hold marks of surprise test. Linked to surprisetest table and then from there to section
    public class SurpriseTestMatrix
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SurpriseTestMatrixID { get; set; }

        [Required(ErrorMessage = "Please specify the marks earned"), Display(Name = "Marks Earned")]
        public float? MarksEarned { get; set; }

        [Display(Name = "Grade Earned")]
        public string Grade { get; set; }

        public string StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public Guid SurpriseTestID { get; set; }

        [ForeignKey("SurpriseTestID")]
        public virtual SurpriseTest Test { get; set; }

    }
}
