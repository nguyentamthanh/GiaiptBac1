namespace GiaiptBac1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_table_Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Customername = c.String(),
                        Address = c.String(),
                        CustomerBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer");
        }
    }
}
