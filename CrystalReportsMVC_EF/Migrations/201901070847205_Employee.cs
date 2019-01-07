namespace CrystalReportsMVC_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 250),
                        LastName = c.String(maxLength: 250),
                        HairDate = c.DateTime(storeType: "date"),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        MobileNo = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(storeType: "date"),
                        Notes = c.String(maxLength: 2050),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
