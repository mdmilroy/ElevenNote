namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Note", "NoteCategory_CategoryId", "dbo.Category");
            DropForeignKey("dbo.Note", "Category_CategoryId", "dbo.Category");
            DropIndex("dbo.Note", new[] { "Category_CategoryId" });
            DropIndex("dbo.Note", new[] { "NoteCategory_CategoryId" });
            RenameColumn(table: "dbo.Note", name: "Category_CategoryId", newName: "CategoryId");
            AlterColumn("dbo.Note", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Note", "CategoryId");
            AddForeignKey("dbo.Note", "CategoryId", "dbo.Category", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Note", "NoteCategory_CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "NoteCategory_CategoryId", c => c.Int());
            DropForeignKey("dbo.Note", "CategoryId", "dbo.Category");
            DropIndex("dbo.Note", new[] { "CategoryId" });
            AlterColumn("dbo.Note", "CategoryId", c => c.Int());
            RenameColumn(table: "dbo.Note", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Note", "NoteCategory_CategoryId");
            CreateIndex("dbo.Note", "Category_CategoryId");
            AddForeignKey("dbo.Note", "Category_CategoryId", "dbo.Category", "CategoryId");
            AddForeignKey("dbo.Note", "NoteCategory_CategoryId", "dbo.Category", "CategoryId");
        }
    }
}
