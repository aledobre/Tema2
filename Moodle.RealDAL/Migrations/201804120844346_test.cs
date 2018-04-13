namespace Moodle.RealDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Token = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        GroupNo = c.Int(nullable: false),
                        Hobby = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
