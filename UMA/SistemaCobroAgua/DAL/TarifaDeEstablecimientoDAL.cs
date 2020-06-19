using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class TarifaDeEstablecimientoDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<TarifaDeEstablecimiento> ObtenerTarifaDeEstablecimientos()
        {
            return db.TarifaDeEstablecimientos.ToList();
        }
        //detalles
        public TarifaDeEstablecimiento ObtenerTarifaDeEstablecimiento(int id)
        {
            TarifaDeEstablecimiento tarifaDeEstablecimiento = db.TarifaDeEstablecimientos.Find(id);
            return tarifaDeEstablecimiento;
        }
        //creacion de datos
        public void CrearTarifaDeEstablecimiento(TarifaDeEstablecimiento pTarifaDeEstablecimiento)
        {
            db.TarifaDeEstablecimientos.Add(pTarifaDeEstablecimiento);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarTarifaDeEstablecimiento(TarifaDeEstablecimiento pTarifaDeEstablecimiento)
        {
            db.Entry(pTarifaDeEstablecimiento).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarTarifaDeEstablecimiento(int id)
        {
            TarifaDeEstablecimiento tarifaDeEstablecimiento = db.TarifaDeEstablecimientos.Find(id);
            db.TarifaDeEstablecimientos.Remove(tarifaDeEstablecimiento);
            db.SaveChanges();
        }
        //metodo para buscar
        //busca por tarifa rango
        public List<TarifaDeEstablecimiento> Buscar(TarifaDeEstablecimiento pTarifaDeEstablecimiento)
        {
            var TarifaDeEstablecimientos = from s in db.TarifaDeEstablecimientos
                                           select s;
            TarifaDeEstablecimientos = db.TarifaDeEstablecimientos.Where(
                s => s.RangosDeConsumoEnMetrosCubicos.ToUpper().Contains(pTarifaDeEstablecimiento.RangosDeConsumoEnMetrosCubicos.ToUpper()) ||
                s.RangosDeConsumoEnMetrosCubicos.ToLower().Contains(pTarifaDeEstablecimiento.RangosDeConsumoEnMetrosCubicos.ToLower())
                );
            return TarifaDeEstablecimientos.ToList();
        }
    }
}
