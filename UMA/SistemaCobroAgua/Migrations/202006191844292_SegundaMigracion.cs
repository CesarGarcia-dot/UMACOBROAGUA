namespace SistemaCobroAgua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigracion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DetalleFactura", "CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.DetalleFactura", "ServicioID", "dbo.Servicio");
            DropIndex("dbo.DetalleFactura", new[] { "ServicioID" });
            DropIndex("dbo.DetalleFactura", new[] { "CabezeraFacturaID" });
            AddColumn("dbo.CabezeraFactura", "DetalleFactura_DetalleFacturaID", c => c.Int());
            AddColumn("dbo.DetalleFactura", "CabezeraFactura_CabezeraFacturaID", c => c.Int());
            AddColumn("dbo.DetalleFactura", "Servicio_ServicioID", c => c.Int());
            AddColumn("dbo.Servicio", "DetalleFactura_DetalleFacturaID", c => c.Int());
            CreateIndex("dbo.CabezeraFactura", "DetalleFactura_DetalleFacturaID");
            CreateIndex("dbo.DetalleFactura", "CabezeraFactura_CabezeraFacturaID");
            CreateIndex("dbo.DetalleFactura", "Servicio_ServicioID");
            CreateIndex("dbo.Servicio", "DetalleFactura_DetalleFacturaID");
            AddForeignKey("dbo.CabezeraFactura", "DetalleFactura_DetalleFacturaID", "dbo.DetalleFactura", "DetalleFacturaID");
            AddForeignKey("dbo.Servicio", "DetalleFactura_DetalleFacturaID", "dbo.DetalleFactura", "DetalleFacturaID");
            AddForeignKey("dbo.DetalleFactura", "CabezeraFactura_CabezeraFacturaID", "dbo.CabezeraFactura", "CabezeraFacturaID");
            AddForeignKey("dbo.DetalleFactura", "Servicio_ServicioID", "dbo.Servicio", "ServicioID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleFactura", "Servicio_ServicioID", "dbo.Servicio");
            DropForeignKey("dbo.DetalleFactura", "CabezeraFactura_CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.Servicio", "DetalleFactura_DetalleFacturaID", "dbo.DetalleFactura");
            DropForeignKey("dbo.CabezeraFactura", "DetalleFactura_DetalleFacturaID", "dbo.DetalleFactura");
            DropIndex("dbo.Servicio", new[] { "DetalleFactura_DetalleFacturaID" });
            DropIndex("dbo.DetalleFactura", new[] { "Servicio_ServicioID" });
            DropIndex("dbo.DetalleFactura", new[] { "CabezeraFactura_CabezeraFacturaID" });
            DropIndex("dbo.CabezeraFactura", new[] { "DetalleFactura_DetalleFacturaID" });
            DropColumn("dbo.Servicio", "DetalleFactura_DetalleFacturaID");
            DropColumn("dbo.DetalleFactura", "Servicio_ServicioID");
            DropColumn("dbo.DetalleFactura", "CabezeraFactura_CabezeraFacturaID");
            DropColumn("dbo.CabezeraFactura", "DetalleFactura_DetalleFacturaID");
            CreateIndex("dbo.DetalleFactura", "CabezeraFacturaID");
            CreateIndex("dbo.DetalleFactura", "ServicioID");
            AddForeignKey("dbo.DetalleFactura", "ServicioID", "dbo.Servicio", "ServicioID", cascadeDelete: true);
            AddForeignKey("dbo.DetalleFactura", "CabezeraFacturaID", "dbo.CabezeraFactura", "CabezeraFacturaID", cascadeDelete: true);
        }
    }
}
