using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Event
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EventID { get; set; }

        [Display(Name="Event Photo")]
        public string Photo { get; set; }

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

        public Guid AddressID { get; set; }

        [Required(ErrorMessage="Please enter where it is happening so that people may find the event to attend"), Display(Name="Event Location"), ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        //Experimental for now dunno implementation
        [Display(Name="Event Location")]
        public DbGeography LocationLatLong { get; set; }

        [Display(Name="Attending Teachers")]
        public ICollection<Teacher> AttendingTeachers { get; set; }

        [Display(Name = "Attending Students")]
        public ICollection<Student> AttendingStudents { get; set; }

        [Display(Name = "Attending Parents")]
        public ICollection<Parent> AttendingParents { get; set; }

        [Display(Name = "Attending Non Teaching Faculty")]
        public ICollection<NonTeachingFaculty> AttendingNonTeachingFaculty { get; set; }
    }
}
