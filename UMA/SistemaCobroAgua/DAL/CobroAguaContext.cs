using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class CobroAguaContext : DbContext
    {
        //constructor para crear la base de datos en base se coloca
        //la cadena de conexion. Se utiliza con entity framework
        //la arroba se usa para que acepte cualquier simbolo en la conexio a SQL Server
        const string miConexionSqlServer = @"Data Source=;Initial Catalog=CobroAguaDB;Integrated Security=True"; 
        public CobroAguaContext() : base(miConexionSqlServer)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TarifaResidencial> TarifaResidencials { get; set; }
        public DbSet<TarifaDeEstablecimiento> TarifaDeEstablecimientos { get; set; }
        public DbSet<CabezeraFactura> CabezeraFacturas { get; set; }
        public DbSet<SubCabezeraFactura> SubCabezeraFacturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<PieFactura> PieFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        //quita los pluraes en las tablas en SQl Server
        //tambien aqui podemos hacer las relaciones y transacciones de la base de datos (Nivel Avanzado en Entity Framework)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       
    }
}
