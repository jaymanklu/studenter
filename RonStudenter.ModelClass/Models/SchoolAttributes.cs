using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    //For schoolattributes. Do put it into DB context
    public class SchoolAttributes
    {
        //For period times it has to pick up from this ONLY
        public DateTime[] PeriodTimes { get; set; }

        //More attributes will be put and polled out from here
    }

    public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    public enum ClassTimes { }
    public enum Breaktimes { }
}
