namespace Moodle.RealDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAllTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Laboratory", newName: "Laboratories");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Laboratories", newName: "Laboratory");
        }
    }
}
