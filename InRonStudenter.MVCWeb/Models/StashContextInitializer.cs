using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InRonStudenter.MVCWeb.Models
{
    public class StashContextInitializer : DropCreateDatabaseIfModelChanges<StashContext>
    {
        protected override void Seed(StashContext context)
        {
            base.Seed(context);
        }
    }
}