using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Event
    {
        public int EventID { get; set; }

        [Display(Name="Event Photo")]
        public byte[] Photo { get; set; }

        [Required(ErrorMessage="Please enter an event name"), Display(Name="Event Name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter some details of the Events"), Display(Name="Event Details"), DataType(DataType.MultilineText)]
        public string Details { get; set; }

        [Display(Name="Event Host")]
        public string Host { get; set; }

        [Display(Name="Event Guests"), DataType(DataType.MultilineText)]
        public string Guests { get; set; }

        [DataType(DataType.DateTime), Required(ErrorMessage="Please enter the time of event"), Display(Name="Event Date and Time")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage="Please enter where it is happening so that people may find the event to attend"), Display(Name="Event Location")]
        public string Location { get; set; }

        //Experimental for now dunno implementation
        [Display(Name="Event Location")]
        public DbGeography Location { get; set; }

        [Display(Name="Attending Teachers")]
        public IList<Teacher> AttendingTeachers { get; set; }

        [Display(Name = "Attending Students")]
        public IList<Student> AttendingStudents { get; set; }

        [Display(Name = "Attending Parents")]
        public IList<Parent> AttendingParents { get; set; }

        [Display(Name = "Attending Non Teaching Faculty")]
        public IList<NonTeachingFaculty> AttendingNonTeachingFaculty { get; set; }
    }
}
