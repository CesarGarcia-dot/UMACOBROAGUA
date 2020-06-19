using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class SubCabezeraFacturaDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<SubCabezeraFactura> ObtenerSubCabezeraFacturas()
        {
            return db.SubCabezeraFacturas.ToList();
        }
        //detalles
        public SubCabezeraFactura ObtenerSubCabezeraFactura(int id)
        {
            SubCabezeraFactura subCabezeraFactura = db.SubCabezeraFacturas.Find(id);
            return subCabezeraFactura;
        }
        //creacion de datos
        public void CrearSubCabezeraFactura(SubCabezeraFactura pSubCabezeraFactura)
        {
            db.SubCabezeraFacturas.Add(pSubCabezeraFactura);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarSubCabezeraFactura(SubCabezeraFactura pSubCabezeraFactura)
        {
            db.Entry(pSubCabezeraFactura).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarSubCabezeraFactura(int id)
        {
            SubCabezeraFactura subCabezeraFactura = db.SubCabezeraFacturas.Find(id);
            db.SubCabezeraFacturas.Remove(subCabezeraFactura);
            db.SaveChanges();
        }
        //buscar cabezera en sub cabezera por medio de ID
        public SubCabezeraFactura EncontrarCabezera(SubCabezeraFactura pSubCabezeraFactura)
        {
            SubCabezeraFactura subCabezeraFactura = db.SubCabezeraFacturas.FirstOrDefault(x => x.CabezeraFacturaID == pSubCabezeraFactura.CabezeraFacturaID);
            return subCabezeraFactura;
        }
    }
}
