namespace Moodle.RealDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAll : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LaboratoryDTOes", newName: "Laboratory");
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        LabId = c.Int(nullable: false),
                        AttendanceStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Laboratory", t => t.LabId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.LabId);
            
            CreateTable(
                "dbo.Submissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        AssignmentId = c.Int(nullable: false),
                        Link = c.String(),
                        Remark = c.String(),
                        Grade = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assignments", t => t.AssignmentId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.AssignmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Submissions", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Submissions", "AssignmentId", "dbo.Assignments");
            DropForeignKey("dbo.Attendance", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Attendance", "LabId", "dbo.Laboratory");
            DropIndex("dbo.Submissions", new[] { "AssignmentId" });
            DropIndex("dbo.Submissions", new[] { "StudentId" });
            DropIndex("dbo.Attendance", new[] { "LabId" });
            DropIndex("dbo.Attendance", new[] { "StudentId" });
            DropTable("dbo.Submissions");
            DropTable("dbo.Attendance");
            RenameTable(name: "dbo.Laboratory", newName: "LaboratoryDTOes");
        }
    }
}
