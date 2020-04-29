namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lolwat2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUser", "Name", c => c.String());
            AddColumn("dbo.ApplicationUser", "PostId", c => c.Int());
            AddColumn("dbo.ApplicationUser", "CommentId", c => c.Int());
            CreateIndex("dbo.ApplicationUser", "PostId");
            CreateIndex("dbo.ApplicationUser", "CommentId");
            AddForeignKey("dbo.ApplicationUser", "CommentId", "dbo.Comment", "CommentId");
            AddForeignKey("dbo.ApplicationUser", "PostId", "dbo.Post", "PostId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUser", "PostId", "dbo.Post");
            DropForeignKey("dbo.ApplicationUser", "CommentId", "dbo.Comment");
            DropIndex("dbo.ApplicationUser", new[] { "CommentId" });
            DropIndex("dbo.ApplicationUser", new[] { "PostId" });
            DropColumn("dbo.ApplicationUser", "CommentId");
            DropColumn("dbo.ApplicationUser", "PostId");
            DropColumn("dbo.ApplicationUser", "Name");
        }
    }
}
