namespace InRonStudenter.MVCWeb.StudenterMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Guid(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        Area = c.String(nullable: false),
                        CityTownVillage = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        AddressPINCode = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
