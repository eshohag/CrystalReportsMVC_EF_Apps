namespace CrystalReportsMVC_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee_NotNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "HairDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Employees", "Salary", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Employees", "HairDate", c => c.DateTime(storeType: "date"));
        }
    }
}
