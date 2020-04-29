namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lolwat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "PostId", "dbo.Post");
            DropForeignKey("dbo.LikePost", "PostId", "dbo.Post");
            AddColumn("dbo.ApplicationUser", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddForeignKey("dbo.Comment", "PostId", "dbo.Post", "PostId");
            AddForeignKey("dbo.LikePost", "PostId", "dbo.Post", "PostId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LikePost", "PostId", "dbo.Post");
            DropForeignKey("dbo.Comment", "PostId", "dbo.Post");
            DropColumn("dbo.ApplicationUser", "Discriminator");
            AddForeignKey("dbo.LikePost", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
            AddForeignKey("dbo.Comment", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
        }
    }
}
