using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class TimeTable
    {
        public Int16 TimeTableID { get; set; }
        public String Class { get; set; }
        public IDictionary<IDictionary<String, String>, IDictionary<String, String>> TimeTableHash { get; set; }
    }
}
