using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class FacturaDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<Factura> ObtenerFacturas()
        {
            return db.Facturas.ToList();
        }
        //detalles
        public Factura ObtenerFactura(int id)
        {
            Factura factura = db.Facturas.Find(id);
            return factura;
        }
        //creacion de datos
        public void CrearFactura(Factura pFactura)
        {
            db.Facturas.Add(pFactura);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarFactura(Factura pFactura)
        {
            db.Entry(pFactura).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarFactura(int id)
        {
            Factura factura = db.Facturas.Find(id);
            db.Facturas.Remove(factura);
            db.SaveChanges();
        }
    }
}
