namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "PostId", c => c.Int(nullable: false));
            AddColumn("dbo.LikePost", "PostId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comment", "PostId");
            AddForeignKey("dbo.Comment", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "PostId", "dbo.Post");
            DropIndex("dbo.Comment", new[] { "PostId" });
            DropColumn("dbo.LikePost", "PostId");
            DropColumn("dbo.Comment", "PostId");
        }
    }
}
