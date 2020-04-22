namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Note", "CategoryID", "dbo.Category");
            DropIndex("dbo.Note", new[] { "CategoryID" });
            DropColumn("dbo.Note", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Note", "CategoryID");
            AddForeignKey("dbo.Note", "CategoryID", "dbo.Category", "CategoryId", cascadeDelete: true);
        }
    }
}
