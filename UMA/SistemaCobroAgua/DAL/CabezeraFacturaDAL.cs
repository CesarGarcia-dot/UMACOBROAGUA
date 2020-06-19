using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class CabezeraFacturaDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<CabezeraFactura> ObtenerCabezerasFacturas()
        {
            return db.CabezeraFacturas.ToList();
        }
        //detalles
        public CabezeraFactura ObtenerCabezeraFactura(int id)
        {
            CabezeraFactura cabezeraFactura = db.CabezeraFacturas.Find(id);
            return cabezeraFactura;
        }
        //creacion de datos
        public void CrearCabezeraFactura(CabezeraFactura pCabezeraFactura)
        {
            db.CabezeraFacturas.Add(pCabezeraFactura);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarCabezeraFactura(CabezeraFactura pCabezeraFactura)
        {
            db.Entry(pCabezeraFactura).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarCliente(int id)
        {
            CabezeraFactura cabezeraFactura = db.CabezeraFacturas.Find(id);
            db.CabezeraFacturas.Remove(cabezeraFactura);
            db.SaveChanges();
        }
        //buscar cabezera numero de factura
        public CabezeraFactura BuscarCabezeraNumeroFactura(CabezeraFactura pCabezeraFactura)
        {
            CabezeraFactura cabezeraFactura = db.CabezeraFacturas.FirstOrDefault(x => x.NumeroDeFactura == pCabezeraFactura.NumeroDeFactura);
            return cabezeraFactura;
        }
    }
}
