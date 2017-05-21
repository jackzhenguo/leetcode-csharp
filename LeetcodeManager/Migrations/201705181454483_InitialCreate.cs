namespace LeetcodeManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Problems",
                c => new
                    {
                        ProblemId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        LtUrl = c.String(),
                        CsdnAddress = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ProblemId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.TagProblem",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        ProblemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.ProblemId })
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.Problems", t => t.ProblemId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.ProblemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagProblem", "ProblemId", "dbo.Problems");
            DropForeignKey("dbo.TagProblem", "TagId", "dbo.Tags");
            DropIndex("dbo.TagProblem", new[] { "ProblemId" });
            DropIndex("dbo.TagProblem", new[] { "TagId" });
            DropTable("dbo.TagProblem");
            DropTable("dbo.Tags");
            DropTable("dbo.Problems");
        }
    }
}
