namespace AbpPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uuid = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(nullable: false, maxLength: 256),
                        ParentId = c.String(),
                        SalePrice = c.Single(nullable: false),
                        Spec = c.String(),
                        UnitId = c.Guid(nullable: false),
                        PurchasePrice = c.Single(nullable: false),
                        Py = c.String(),
                        SpecPy = c.String(),
                        BarCode = c.String(),
                        DataOrg = c.String(),
                        Memo = c.String(),
                        CompanyId = c.Guid(nullable: false),
                        BrandId = c.String(),
                        Unit = c.String(),
                        Rate = c.Single(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
