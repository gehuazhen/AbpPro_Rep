namespace AbpPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_casegroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.M_AJMB",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        mb_mbh = c.Guid(nullable: false),
                        mb_mbmc = c.String(nullable: false, maxLength: 64),
                        mb_cjr = c.String(maxLength: 64),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.M_ZDYSB",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        mb_mbh = c.Int(),
                        excel_column = c.String(nullable: false, maxLength: 64),
                        sys_colcode = c.String(maxLength: 64),
                        sys_colname = c.String(maxLength: 64),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.M_AJMB", t => t.mb_mbh)
                .Index(t => t.mb_mbh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.M_ZDYSB", "mb_mbh", "dbo.M_AJMB");
            DropIndex("dbo.M_ZDYSB", new[] { "mb_mbh" });
            DropTable("dbo.M_ZDYSB");
            DropTable("dbo.M_AJMB");
        }
    }
}
