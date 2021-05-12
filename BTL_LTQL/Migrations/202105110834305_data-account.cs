namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataaccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false),
                        address = c.String(),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
