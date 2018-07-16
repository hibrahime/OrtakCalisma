namespace Calisma.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brans = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ogretmen");
            DropTable("dbo.Ogrencis");
        }
    }
}
