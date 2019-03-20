namespace StellarCoffeeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReceiptTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        IdentityCardNumber = c.String(),
                        RNC = c.String(),
                        Address = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReceiptTypes", t => t.ReceiptTypeId, cascadeDelete: true)
                .Index(t => t.ReceiptTypeId);
            
            CreateTable(
                "dbo.ReceiptTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            Sql(SqlStrings.ReceiptTypeSQL);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ReceiptTypeId", "dbo.ReceiptTypes");
            DropIndex("dbo.Clients", new[] { "ReceiptTypeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.ReceiptTypes");
            DropTable("dbo.Clients");
        }
    }
}
