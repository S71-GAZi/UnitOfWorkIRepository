namespace UnitOfWorkRepositoryMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserModelID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserPassword = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserModelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
