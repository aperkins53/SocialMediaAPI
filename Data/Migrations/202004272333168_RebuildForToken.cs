namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RebuildForToken : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.LikePost", "PostId");
            AddForeignKey("dbo.LikePost", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LikePost", "PostId", "dbo.Post");
            DropIndex("dbo.LikePost", new[] { "PostId" });
        }
    }
}
