using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class NonTeachingFaculty
    {
        public Int32 NonTeachingFacultyID { get; set; }
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public Address Address{ get; set; }
        public int MyProperty { get; set; }
    }
}
