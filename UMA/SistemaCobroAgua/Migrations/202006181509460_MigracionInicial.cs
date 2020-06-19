namespace SistemaCobroAgua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CabezeraFactura",
                c => new
                    {
                        CabezeraFacturaID = c.Int(nullable: false, identity: true),
                        NumeroDeCuenta = c.String(),
                        NumeroDeFactura = c.String(),
                        NRC = c.String(),
                        NIT = c.String(),
                        Giro = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CabezeraFacturaID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Departamento = c.String(),
                        Municipio = c.String(),
                        DUI = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.DetalleFactura",
                c => new
                    {
                        DetalleFacturaID = c.Int(nullable: false, identity: true),
                        ServicioID = c.Int(nullable: false),
                        CabezeraFacturaID = c.Int(nullable: false),
                        VentasExentas = c.Double(nullable: false),
                        VentasGravadas = c.Double(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleFacturaID)
                .ForeignKey("dbo.CabezeraFactura", t => t.CabezeraFacturaID, cascadeDelete: true)
                .ForeignKey("dbo.Servicio", t => t.ServicioID, cascadeDelete: true)
                .Index(t => t.ServicioID)
                .Index(t => t.CabezeraFacturaID);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        ServicioID = c.Int(nullable: false, identity: true),
                        NombreDeServicio = c.String(),
                        Precio = c.Double(nullable: false),
                        COD = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioID);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaID = c.Int(nullable: false, identity: true),
                        CabezeraFacturaID = c.Int(nullable: false),
                        SubCabezeraFacturaID = c.Int(nullable: false),
                        PieFacturaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacturaID)
                .ForeignKey("dbo.CabezeraFactura", t => t.CabezeraFacturaID, cascadeDelete: true)
                .ForeignKey("dbo.PieFactura", t => t.PieFacturaID, cascadeDelete: true)
                .ForeignKey("dbo.SubCabezeraFactura", t => t.SubCabezeraFacturaID, cascadeDelete: true)
                .Index(t => t.CabezeraFacturaID)
                .Index(t => t.SubCabezeraFacturaID)
                .Index(t => t.PieFacturaID);
            
            CreateTable(
                "dbo.PieFactura",
                c => new
                    {
                        PieFacturaID = c.Int(nullable: false, identity: true),
                        CabezeraFacturaID = c.Int(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        UltimoDiaDePago = c.String(),
                    })
                .PrimaryKey(t => t.PieFacturaID)
                .ForeignKey("dbo.CabezeraFactura", t => t.CabezeraFacturaID, cascadeDelete: false)
                .Index(t => t.CabezeraFacturaID);
            
            CreateTable(
                "dbo.SubCabezeraFactura",
                c => new
                    {
                        SubCabezeraFacturaID = c.Int(nullable: false, identity: true),
                        CabezeraFacturaID = c.Int(nullable: false),
                        FacturadoDesde = c.DateTime(nullable: false),
                        FacturadoHasta = c.DateTime(nullable: false),
                        DiasFacturados = c.DateTime(nullable: false),
                        MesFacturado = c.DateTime(nullable: false),
                        Region = c.String(),
                        Grupo = c.String(),
                        Ruta = c.String(),
                        FechaEmision = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SubCabezeraFacturaID)
                .ForeignKey("dbo.CabezeraFactura", t => t.CabezeraFacturaID, cascadeDelete: false)
                .Index(t => t.CabezeraFacturaID);
            
            CreateTable(
                "dbo.TarifaDeEstablecimiento",
                c => new
                    {
                        TarifaDeEstablecimientoID = c.Int(nullable: false, identity: true),
                        RangosDeConsumoEnMetrosCubicos = c.String(),
                        TarifaAcueductoM3 = c.Double(nullable: false),
                        TarifaAlcantarillado = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TarifaDeEstablecimientoID);
            
            CreateTable(
                "dbo.TarifaResidencial",
                c => new
                    {
                        TarifaResidencialID = c.Int(nullable: false, identity: true),
                        RangosDeConsumoEnMetrosCubicos = c.String(),
                        TarifaAcueductoPrecioPorM3 = c.Double(nullable: false),
                        TarifasAlcantarillado = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TarifaResidencialID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Departamento = c.String(),
                        Municipio = c.String(),
                        DUI = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factura", "SubCabezeraFacturaID", "dbo.SubCabezeraFactura");
            DropForeignKey("dbo.SubCabezeraFactura", "CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.Factura", "PieFacturaID", "dbo.PieFactura");
            DropForeignKey("dbo.PieFactura", "CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.Factura", "CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.DetalleFactura", "ServicioID", "dbo.Servicio");
            DropForeignKey("dbo.DetalleFactura", "CabezeraFacturaID", "dbo.CabezeraFactura");
            DropForeignKey("dbo.CabezeraFactura", "ClienteID", "dbo.Cliente");
            DropIndex("dbo.SubCabezeraFactura", new[] { "CabezeraFacturaID" });
            DropIndex("dbo.PieFactura", new[] { "CabezeraFacturaID" });
            DropIndex("dbo.Factura", new[] { "PieFacturaID" });
            DropIndex("dbo.Factura", new[] { "SubCabezeraFacturaID" });
            DropIndex("dbo.Factura", new[] { "CabezeraFacturaID" });
            DropIndex("dbo.DetalleFactura", new[] { "CabezeraFacturaID" });
            DropIndex("dbo.DetalleFactura", new[] { "ServicioID" });
            DropIndex("dbo.CabezeraFactura", new[] { "ClienteID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.TarifaResidencial");
            DropTable("dbo.TarifaDeEstablecimiento");
            DropTable("dbo.SubCabezeraFactura");
            DropTable("dbo.PieFactura");
            DropTable("dbo.Factura");
            DropTable("dbo.Servicio");
            DropTable("dbo.DetalleFactura");
            DropTable("dbo.Cliente");
            DropTable("dbo.CabezeraFactura");
        }
    }
}
