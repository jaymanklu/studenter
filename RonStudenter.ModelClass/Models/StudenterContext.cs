using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRonStudenter.ModelLibrary
{
    public class StudenterContext : DbContext
    {
        public DbSet<TimeTable> TimeTables { get; set; }
        int i = 0;
        
    }

    public class calss
    {
        
    }
}
