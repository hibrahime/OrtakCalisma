namespace Calisma.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_names_edited : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ogrencis", newName: "Ogrenciler");
            RenameTable(name: "dbo.Ogretmen", newName: "Ogretmenler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Ogretmenler", newName: "Ogretmen");
            RenameTable(name: "dbo.Ogrenciler", newName: "Ogrencis");
        }
    }
}
