namespace BuildMyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buildTableupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Builds", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Builds", "Name");
        }
    }
}
