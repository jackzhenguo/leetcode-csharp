namespace LeetcodeManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Title : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Problems", "Title", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Problems", "Title", c => c.String(maxLength: 50));
        }
    }
}
