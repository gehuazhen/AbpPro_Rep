namespace AbpPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProducts1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "SalePrice", c => c.Single());
            AlterColumn("dbo.Products", "UnitId", c => c.Guid());
            AlterColumn("dbo.Products", "PurchasePrice", c => c.Single());
            AlterColumn("dbo.Products", "CompanyId", c => c.Guid());
            AlterColumn("dbo.Products", "Rate", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Rate", c => c.Single(nullable: false));
            AlterColumn("dbo.Products", "CompanyId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Products", "PurchasePrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Products", "UnitId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Products", "SalePrice", c => c.Single(nullable: false));
        }
    }
}
