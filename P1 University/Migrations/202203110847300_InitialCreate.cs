namespace P1_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        lessonCode = c.Int(nullable: false),
                        title = c.String(),
                        field = c.String(),
                        unitNum = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LessonId = c.Int(nullable: false),
                        teacherId = c.Int(nullable: false),
                        day = c.Int(nullable: false),
                        lessonHR = c.DateTimeOffset(nullable: false, precision: 7),
                        classNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SelectionUnits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sectionId = c.Int(nullable: false),
                        studentId = c.Int(nullable: false),
                        termNum = c.Int(nullable: false),
                        number = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        studentCode = c.Int(nullable: false),
                        address = c.String(),
                        name = c.String(),
                        fatherName = c.String(),
                        family = c.String(),
                        age = c.Byte(nullable: false),
                        nationalID = c.Int(nullable: false),
                        phone = c.String(),
                        field = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        degree = c.String(),
                        name = c.String(),
                        fatherName = c.String(),
                        family = c.String(),
                        age = c.Byte(nullable: false),
                        nationalID = c.Int(nullable: false),
                        phone = c.String(),
                        field = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.SelectionUnits");
            DropTable("dbo.Sections");
            DropTable("dbo.Lessons");
        }
    }
}
