using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InRonStudenter.ModelLibrary;

namespace InRonStudenter.MVCWeb.Models
{
    public class StudenterContext : DbContext 
    {
        public DbSet<Address> Addresses { get; set; }
    }
}