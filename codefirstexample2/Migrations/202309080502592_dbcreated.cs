namespace codefirstexample2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        catename = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        fullprice = c.Single(nullable: false),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "category_Id", "dbo.categories");
            DropIndex("dbo.Courses", new[] { "category_Id" });
            DropTable("dbo.Courses");
            DropTable("dbo.categories");
        }
    }
}
