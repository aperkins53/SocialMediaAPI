namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sickOfThis : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Post", "ModifiedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
    }
}
