namespace Moodle.RealDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAssig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Deadline = c.DateTime(nullable: false),
                        Description = c.String(),
                        LabId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LaboratoryDTOes", t => t.LabId, cascadeDelete: true)
                .Index(t => t.LabId);
            
            CreateTable(
                "dbo.LaboratoryDTOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LabNumber = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Curricula = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "LabId", "dbo.LaboratoryDTOes");
            DropIndex("dbo.Assignments", new[] { "LabId" });
            DropTable("dbo.LaboratoryDTOes");
            DropTable("dbo.Assignments");
        }
    }
}
