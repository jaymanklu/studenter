using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InRonStudenter.ModelLibrary.EFContext
{
    public class StudenterContextInitializer : DropCreateDatabaseAlways<StudenterContext>
    {
        protected override void Seed(StudenterContext context)
        {
            base.Seed(context);
        }
    }
}
