namespace BuildMyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateStorageTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Storages(Name, BrandId,Form,Size,Price) VALUES('Optane 900P',4,2.5,1000,596)");


        }
        
        public override void Down()
        {
        }
    }
}
