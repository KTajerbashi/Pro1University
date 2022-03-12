namespace P1_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "address");
        }
    }
}
