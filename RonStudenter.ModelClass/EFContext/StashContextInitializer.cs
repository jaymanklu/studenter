using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InRonStudenter.ModelLibrary.EFContext
{
    class StashContextInitializer : DropCreateDatabaseAlways<StashContext>
    {
        protected override void Seed(StashContext context)
        {
            base.Seed(context);
        }
    }
}
