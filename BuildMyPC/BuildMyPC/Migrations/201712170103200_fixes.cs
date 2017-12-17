namespace BuildMyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FullBuilds", "CaseId", "dbo.Cases");
            DropForeignKey("dbo.FullBuilds", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.FullBuilds", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.FullBuilds", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.FullBuilds", "PowerSupplyId", "dbo.PowerSupplies");
            DropForeignKey("dbo.FullBuilds", "StorageId", "dbo.Storages");
            DropForeignKey("dbo.FullBuilds", "VideoCardId", "dbo.VideoCards");
            DropIndex("dbo.FullBuilds", new[] { "CpuId" });
            DropIndex("dbo.FullBuilds", new[] { "CaseId" });
            DropIndex("dbo.FullBuilds", new[] { "MemoryId" });
            DropIndex("dbo.FullBuilds", new[] { "MotherboardId" });
            DropIndex("dbo.FullBuilds", new[] { "PowerSupplyId" });
            DropIndex("dbo.FullBuilds", new[] { "StorageId" });
            DropIndex("dbo.FullBuilds", new[] { "VideoCardId" });
            DropTable("dbo.FullBuilds");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FullBuilds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        CpuId = c.Int(nullable: false),
                        CaseId = c.Int(nullable: false),
                        MemoryId = c.Int(nullable: false),
                        MotherboardId = c.Int(nullable: false),
                        PowerSupplyId = c.Int(nullable: false),
                        StorageId = c.Int(nullable: false),
                        VideoCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.FullBuilds", "VideoCardId");
            CreateIndex("dbo.FullBuilds", "StorageId");
            CreateIndex("dbo.FullBuilds", "PowerSupplyId");
            CreateIndex("dbo.FullBuilds", "MotherboardId");
            CreateIndex("dbo.FullBuilds", "MemoryId");
            CreateIndex("dbo.FullBuilds", "CaseId");
            CreateIndex("dbo.FullBuilds", "CpuId");
            AddForeignKey("dbo.FullBuilds", "VideoCardId", "dbo.VideoCards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "StorageId", "dbo.Storages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "PowerSupplyId", "dbo.PowerSupplies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "MotherboardId", "dbo.Motherboards", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "MemoryId", "dbo.Memories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "CpuId", "dbo.CPUs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FullBuilds", "CaseId", "dbo.Cases", "Id", cascadeDelete: true);
        }
    }
}
