using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCobroAgua.Modelos;

namespace SistemaCobroAgua.DAL
{
    public class ServicioDAL
    {
        //inicio de base de datos conexion
        private CobroAguaContext db = new CobroAguaContext();
        //lista
        public List<Servicio> ObtenerServicios()
        {
            return db.Servicios.ToList();
        }
        //detalles
        public Servicio ObtenerServicio(int id)
        {
            Servicio servicio = db.Servicios.Find(id);
            return servicio;
        }
        //creacion de datos
        public void CrearServicio(Servicio pServicio)
        {
            db.Servicios.Add(pServicio);
            db.SaveChanges();
        }
        //edicion de datos
        public void EditarServicio(Servicio pServicio)
        {
            db.Entry(pServicio).State = EntityState.Modified;
            db.SaveChanges();
        }
        //eliminacion de datos
        public void EliminarServicio(int id)
        {
            Servicio servicio = db.Servicios.Find(id);
            db.Servicios.Remove(servicio);
            db.SaveChanges();
        }
        //metodo para buscar
        //busca por nombre de servicio
        public List<Servicio> Buscar(Servicio pServicio)
        {
            var Servicios = from s in db.Servicios
                            select s;
            Servicios = db.Servicios.Where(
                s => s.NombreDeServicio.ToUpper().Contains(pServicio.NombreDeServicio.ToUpper()) ||
                s.NombreDeServicio.ToLower().Contains(pServicio.NombreDeServicio.ToLower())
                );
            return Servicios.ToList();
        }
    }
}
