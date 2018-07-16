namespace Calisma.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ogrencino_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ogrenciler", "OgrenciNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ogrenciler", "OgrenciNo");
        }
    }
}
