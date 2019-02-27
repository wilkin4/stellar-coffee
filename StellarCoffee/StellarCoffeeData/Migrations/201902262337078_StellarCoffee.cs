namespace StellarCoffeeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StellarCoffee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdentityCardNumber = c.String(),
                        RNC = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        ITBIS = c.Single(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql(SqlStrings.UserSQL);
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Clients");
        }
    }
}
