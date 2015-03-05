namespace InRonStudenter.MVCWeb.AppDBMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class AppDBConfiguration : DbMigrationsConfiguration<InRonStudenter.MVCWeb.Models.ApplicationDbContext>
    {
        public AppDBConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InRonStudenter.MVCWeb.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
