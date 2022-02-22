namespace BijBijCup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameNets",
                c => new
                    {
                        GameNetID = c.Int(nullable: false, identity: true),
                        GameNetName = c.String(nullable: false, maxLength: 50),
                        Capacity = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.GameNetID);
            
            CreateTable(
                "dbo.RegisterUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 11),
                        CodeMeli = c.String(nullable: false, maxLength: 10),
                        RegDate = c.DateTime(nullable: false),
                        GameNetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.GameNets", t => t.GameNetID, cascadeDelete: true)
                .Index(t => t.GameNetID);
            
            CreateTable(
                "dbo.SMSHis",
                c => new
                    {
                        SMSID = c.Int(nullable: false, identity: true),
                        SendDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Text = c.String(),
                        Result = c.String(),
                    })
                .PrimaryKey(t => t.SMSID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisterUsers", "GameNetID", "dbo.GameNets");
            DropIndex("dbo.RegisterUsers", new[] { "GameNetID" });
            DropTable("dbo.SMSHis");
            DropTable("dbo.RegisterUsers");
            DropTable("dbo.GameNets");
        }
    }
}
