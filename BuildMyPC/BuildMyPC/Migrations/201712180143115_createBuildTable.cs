namespace BuildMyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBuildTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Builds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPUId = c.Int(nullable: false),
                        MemoryId = c.Int(nullable: false),
                        MotherboardId = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        VideoCardId = c.Int(nullable: false),
                        CaseId = c.Int(nullable: false),
                        PowerSupplyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cases", t => t.CaseId, cascadeDelete: false)
                .ForeignKey("dbo.CPUs", t => t.CPUId, cascadeDelete: false)
                .ForeignKey("dbo.Memories", t => t.MemoryId, cascadeDelete: false)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId, cascadeDelete: false)
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupplyId, cascadeDelete: false)
                .ForeignKey("dbo.Storages", t => t.StorageId, cascadeDelete: false)
                .ForeignKey("dbo.VideoCards", t => t.VideoCardId, cascadeDelete: false)
                .Index(t => t.CPUId)
                .Index(t => t.MemoryId)
                .Index(t => t.MotherboardId)
                .Index(t => t.StorageId)
                .Index(t => t.VideoCardId)
                .Index(t => t.CaseId)
                .Index(t => t.PowerSupplyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Builds", "VideoCardId", "dbo.VideoCards");
            DropForeignKey("dbo.Builds", "StorageId", "dbo.Storages");
            DropForeignKey("dbo.Builds", "PowerSupplyId", "dbo.PowerSupplies");
            DropForeignKey("dbo.Builds", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Builds", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.Builds", "CPUId", "dbo.CPUs");
            DropForeignKey("dbo.Builds", "CaseId", "dbo.Cases");
            DropIndex("dbo.Builds", new[] { "PowerSupplyId" });
            DropIndex("dbo.Builds", new[] { "CaseId" });
            DropIndex("dbo.Builds", new[] { "VideoCardId" });
            DropIndex("dbo.Builds", new[] { "StorageId" });
            DropIndex("dbo.Builds", new[] { "MotherboardId" });
            DropIndex("dbo.Builds", new[] { "MemoryId" });
            DropIndex("dbo.Builds", new[] { "CPUId" });
            DropTable("dbo.Builds");
        }
    }
}
