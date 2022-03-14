namespace P1_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodeA1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sections", "day", c => c.Short(nullable: false));
            AlterColumn("dbo.Sections", "classNum", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sections", "classNum", c => c.Int(nullable: false));
            AlterColumn("dbo.Sections", "day", c => c.Int(nullable: false));
        }
    }
}
