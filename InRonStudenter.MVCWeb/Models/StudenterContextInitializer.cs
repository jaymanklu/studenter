using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InRonStudenter.MVCWeb.Models
{
    public class StudenterContextInitializer : DropCreateDatabaseIfModelChanges<StudenterContext>
    {
        protected override void Seed(StudenterContext context)
        {
 	         base.Seed(context);
        }
    }
}