using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class Event
    {
        public int EventID { get; set; }
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Host { get; set; }
        public string Guests { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public double GeoLat { get; set; }
        public Double GeoLong { get; set; }
        public IList<Teacher> AttendingTeachers { get; set; }
        public IList<Student> AttendingStudents { get; set; }
        public IList<Parent> AttendingParents { get; set; }
        public IList<NonTeachingFaculty> AttendingNonTeachingFaculty { get; set; }
    }
}
