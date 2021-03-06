namespace PracticasemU3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Peliculas", "Hora", c => c.Int(nullable: false));
            DropColumn("dbo.Peliculas", "Precio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Peliculas", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Peliculas", "Hora");
        }
    }
}
