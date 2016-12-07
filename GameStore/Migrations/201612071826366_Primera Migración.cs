namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeraMigración : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transaccions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Direccion = c.String(maxLength: 200),
                        Correo = c.String(nullable: false),
                        TarjetaCredito = c.String(nullable: false),
                        FechaExpiracion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Videojuegoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Single(nullable: false),
                        Descripcion = c.String(maxLength: 200),
                        Requerimiento = c.String(),
                        GeneroId = c.Int(nullable: false),
                        CarrocomprasId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carrocompras", t => t.CarrocomprasId)
                .ForeignKey("dbo.Generoes", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId)
                .Index(t => t.CarrocomprasId);
            
            CreateTable(
                "dbo.Carrocompras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 255),
                        Filetype = c.Int(nullable: false),
                        VideojuegoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Videojuegoes", t => t.VideojuegoId, cascadeDelete: true)
                .Index(t => t.VideojuegoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "VideojuegoId", "dbo.Videojuegoes");
            DropForeignKey("dbo.Videojuegoes", "GeneroId", "dbo.Generoes");
            DropForeignKey("dbo.Videojuegoes", "CarrocomprasId", "dbo.Carrocompras");
            DropIndex("dbo.Images", new[] { "VideojuegoId" });
            DropIndex("dbo.Videojuegoes", new[] { "CarrocomprasId" });
            DropIndex("dbo.Videojuegoes", new[] { "GeneroId" });
            DropTable("dbo.Images");
            DropTable("dbo.Generoes");
            DropTable("dbo.Carrocompras");
            DropTable("dbo.Videojuegoes");
            DropTable("dbo.Transaccions");
        }
    }
}
