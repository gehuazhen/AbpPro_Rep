namespace AbpPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201804172028_add_mdict : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.M_DICT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dict_code = c.String(nullable: false, maxLength: 64),
                        dict_name = c.String(nullable: false, maxLength: 64),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.M_DICT");
        }
    }
}
