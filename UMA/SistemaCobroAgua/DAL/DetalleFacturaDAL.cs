using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;


namespace SistemaCobroAgua.DAL
{
    public class DetalleFacturaDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<DetalleFactura> ObtenerDetalleFacturas()
        {
            return db.DetalleFacturas.ToList();
        }
        //detalles
        public List<DetalleFactura> ObtenerDetalleFactura(int id)
        {
            List<DetalleFactura> detalleFactura = db.DetalleFacturas.Include(x => x.Servicios).Where(c => c.CabezeraFacturaID == id).ToList();
            return detalleFactura;
        }
        //creacion de datos
        public void CrearDetalleFactura(DetalleFactura pDetalleFactura)
        {
            db.DetalleFacturas.Add(pDetalleFactura);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarDetalleFactura(DetalleFactura pDetalleFactura)
        {
            db.Entry(pDetalleFactura).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarDetalleFactura(int id)
        {
            DetalleFactura detalleFactura = db.DetalleFacturas.Find(id);
            db.DetalleFacturas.Remove(detalleFactura);
            db.SaveChanges();
        }
    }
}
