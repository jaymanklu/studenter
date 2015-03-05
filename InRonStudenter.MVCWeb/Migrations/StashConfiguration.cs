namespace InRonStudenter.MVCWeb.StashMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StashConfiguration : DbMigrationsConfiguration<InRonStudenter.MVCWeb.Models.StashContext>
    {
        public StashConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InRonStudenter.MVCWeb.Models.StashContext context)
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
