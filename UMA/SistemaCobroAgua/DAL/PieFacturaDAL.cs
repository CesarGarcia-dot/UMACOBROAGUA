using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class PieFacturaDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<PieFactura> ObtenerPieFactura()
        {
            return db.PieFacturas.ToList();
        }
        //detalles
        public PieFactura ObtenerPieFactura(int id)
        {
            PieFactura pieFactura = db.PieFacturas.Find(id);
            return pieFactura;
        }
        //creacion de datos
        public void CrearPieFactura(PieFactura pPieFactura)
        {
            db.PieFacturas.Add(pPieFactura);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarPieFactura(PieFactura pPieFactura)
        {
            db.Entry(pPieFactura).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarPieFactura(int id)
        {
            PieFactura pieFactura = db.PieFacturas.Find(id);
            db.PieFacturas.Remove(pieFactura);
            db.SaveChanges();
        }
    }
}
