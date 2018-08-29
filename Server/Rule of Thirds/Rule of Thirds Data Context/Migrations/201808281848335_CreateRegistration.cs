namespace Rule_of_Thirds_Data_Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ClaimID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Value = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ClaimID)
                .ForeignKey("dbo.UserCredentials", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.UserCredentials",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Claims", "UserID", "dbo.UserCredentials");
            DropIndex("dbo.Claims", new[] { "UserID" });
            DropTable("dbo.UserCredentials");
            DropTable("dbo.Claims");
        }
    }
}
