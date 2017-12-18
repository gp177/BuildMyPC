namespace BuildMyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateVideoCards : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VideoCards(Name, BrandId,Memory,CoreClock,Price) VALUES('GeForce GTX 1050 Ti',7,4,1354,219)");
        }
        
        public override void Down()
        {
        }
    }
}
