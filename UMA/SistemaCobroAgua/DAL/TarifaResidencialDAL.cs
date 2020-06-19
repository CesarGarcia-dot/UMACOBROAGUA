using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class TarifaResidencialDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<TarifaResidencial> ObtenerTarifaResidenciales()
        {
            return db.TarifaResidencials.ToList();
        }
        //detalles
        public TarifaResidencial ObtenerTarifaResidencial(int id)
        {
            TarifaResidencial tarifaResidencial = db.TarifaResidencials.Find(id);
            return tarifaResidencial;
        }
        //creacion de datos
        public void CrearTarifaResidencial(TarifaResidencial pTarifaResidencial)
        {
            db.TarifaResidencials.Add(pTarifaResidencial);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarTarifaResidencial(TarifaResidencial pTarifaResidencial)
        {
            db.Entry(pTarifaResidencial).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarTarifaResidencial(int id)
        {
            TarifaResidencial tarifaResidencial = db.TarifaResidencials.Find(id);
            db.TarifaResidencials.Remove(tarifaResidencial);
            db.SaveChanges();
        }

        //metodo para buscar
        //busca por tarifa rango
        public List<TarifaResidencial> Buscar(TarifaResidencial pTarifaResidencial)
        {
            var TarifaResidencials = from s in db.TarifaResidencials
                                     select s;
            TarifaResidencials = db.TarifaResidencials.Where(
                s => s.RangosDeConsumoEnMetrosCubicos.ToUpper().Contains(pTarifaResidencial.RangosDeConsumoEnMetrosCubicos.ToUpper()) ||
                s.RangosDeConsumoEnMetrosCubicos.ToLower().Contains(pTarifaResidencial.RangosDeConsumoEnMetrosCubicos.ToLower()) 
                );
            return TarifaResidencials.ToList();
        }
    }
}
